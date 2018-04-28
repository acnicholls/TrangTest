using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrangTestLib
{
    public class Thermometer
    {
        private Temperature prevTemp;
        private Temperature currentTemp;
        private AlertsRaised NumberOfAlerts = new AlertsRaised();

        public event EventHandler<AlertEventArgs> RaiseAlert;
        public event EventHandler<OutputEventArgs> OutputTemps;
        protected void OnRaiseAlert(AlertEventArgs e)
        {
            RaiseAlert(this, e);
        }
        protected void OnOutputTemps(OutputEventArgs e)
        {
            OutputTemps(this, e);
        }

        /// <summary>
        /// constructore
        /// </summary>
        public Thermometer()
        {
            this.RaiseAlert += Thermometer_RaiseAlert;
        }

        /// <summary>
        /// handles the thermomenters part of raising alerts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Thermometer_RaiseAlert(object sender, AlertEventArgs e)
        {
            NumberOfAlerts.AddTimeRasied(e.AlertId);
        }

        /// <summary>
        /// checks and converts the input temperature
        /// </summary>
        /// <param name="_inputTemp"></param>
        public void InputTemperature(string _inputTemp)
        {
            if (currentTemp != null)
                prevTemp = currentTemp;
            currentTemp = new Temperature(_inputTemp);

            int alertId = 0;
            // check for a match to a threshold temp
            foreach(Data.TrangTest.TemperatureThresholdsRow tr in Data.XMLOperations.ReadXML().TemperatureThresholds)
            {
                double val1 = tr.TempThreshold_Value;
                double val2 = 0;

                DataAccess.TemperatureType thresholdType = new DataAccess.TemperatureType(tr.TempThreshold_TypeID);
                if(thresholdType.Id == currentTemp.TempType.Id)
                    val2 = currentTemp.TempValue;
                else
                {
                    Temperature convTemp = new Temperature(currentTemp.ConvertedTemperature(thresholdType.Indicator));
                    val2 = convTemp.TempValue;
                }

                if(TempValueMatchCheck(val1, val2))
                {
                    // if we have a threshold match, check all other criteria
                    if(CheckAlertCriteria(tr.TempThreshold_ID, out alertId))
                    {
                        // if all criteria are met, raise the alert.
                        DataAccess.TemperatureAlert alert = new DataAccess.TemperatureAlert(alertId);
                        AlertEventArgs args = new AlertEventArgs();
                        args.AlertId = alert.Id;
                        args.AlertName = new DataAccess.TemperatureThreshold(alert.ThresholdId).Name;
                        args.AlertMessage = alert.Message;
                        OnRaiseAlert(args);
                    }
                }

            }

            // invoke the callers output method
            OutputEventArgs outputArgs = new OutputEventArgs();
            outputArgs.InputTemp = currentTemp;
            OnOutputTemps(outputArgs);
        }

        /// <summary>
        /// checks two numerical values to see if they match 
        /// </summary>
        /// <param name="_val1"></param>
        /// <param name="_val2"></param>
        /// <returns></returns>
        private bool TempValueMatchCheck(double _val1, double _val2)
        {
            if (_val1 == _val2)
                return true;
            else
                return false;
        }

        /// <summary>
        /// checks all criteria between the current temperature and the previous temperature
        /// </summary>
        /// <param name="_thresholdId"></param>
        /// <param name="_alertId"></param>
        /// <returns></returns>
        private bool CheckAlertCriteria(int _thresholdId, out int _alertId)
        {
            bool returnValue = true;
            // this threshold may have many alerts
            _alertId = 0;
            var alerts = Data.XMLOperations.ReadXML().TemperatureAlerts.Where(ar => ar.TempAlert_ThresholdID == _thresholdId);
            // check all alerts found
            foreach (Data.TrangTest.TemperatureAlertsRow aRow in alerts)
            {
                // check that the flucuation was larger than the minimum
                bool fluxCheck = FlucuationCheck(aRow.TempAlert_MinFluctuation);

                // check that the direction is valid
                bool dirCheck = DirectionCheck(aRow.TempAlert_Direction);

                // check that we haven't already alerted the user more than the allowed times
                bool timesCheck = TimesCheck(aRow.TempAlert_ID, aRow.TempAlert_Times);
                // now put those three together to check if we've matched an alert.
                returnValue = fluxCheck & dirCheck & timesCheck;
                if(returnValue)
                {
                    _alertId = aRow.TempAlert_ID;
                    break;
                }
            }
            return returnValue;
        }

        /// <summary>
        /// checks if the fluctuation was over the current alert allowed limit
        /// </summary>
        /// <param name="_minFlux"></param>
        /// <returns></returns>
        private bool FlucuationCheck(double _minFlux)
        {
            if (_minFlux > 0)
            {
                double checkValue = ChangeAmount;
                if (checkValue < 0)
                    checkValue = checkValue * -1;
                return checkValue > _minFlux;
            }
            else
                return true;
        }

        /// <summary>
        /// checks if the direction between the previous temp and current temp match the current alert
        /// </summary>
        /// <param name="_direction"></param>
        /// <returns></returns>
        private bool DirectionCheck(string _direction)
        {
            if (_direction != "")
            {
                string dir = CheckDirectionOfChange;
                if (dir != "N")
                    return dir == _direction;
                else
                    return false;
            }
            else
                return true;
        }

        /// <summary>
        /// checks if we've reached the alert limit for a certain alert.
        /// </summary>
        /// <param name="_alertId"></param>
        /// <param name="_timesAllowed"></param>
        /// <returns></returns>
        private bool TimesCheck(int _alertId, string _timesAllowed)
        {
            int allowed = 0;
            if (_timesAllowed == "O")
                allowed = 1;
            return allowed == 0 | NumberOfAlerts.CheckTimesRaised(_alertId) == 0;
        }

        /// <summary>
        /// detects the direction of change between two temperatures
        /// </summary>
        private string CheckDirectionOfChange
        {
            get
            {
                if (prevTemp != null)
                {
                    if (prevTemp.TempType.Indicator == currentTemp.TempType.Indicator)
                    {
                        if (prevTemp.TempValue > currentTemp.TempValue)
                            return "D";
                        else if (prevTemp.TempValue < currentTemp.TempValue)
                            return "R";
                        else
                            return "N";
                    }
                    else
                    {
                        Temperature newCurrentTemp = new Temperature(currentTemp.ConvertedTemperature(prevTemp.TempType.Indicator));
                        if (prevTemp.TempValue > newCurrentTemp.TempValue)
                            return "D";
                        else if (prevTemp.TempValue < newCurrentTemp.TempValue)
                            return "R";
                        else
                            return "N";
                    }
                }
                else
                    return "N";
            }
        }

        /// <summary>
        /// detects the amount of change between two temperatures
        /// </summary>
        private double ChangeAmount
        {
            get
            {
                if (prevTemp != null)
                {
                    if (prevTemp.TempType.Indicator == currentTemp.TempType.Indicator)
                    {
                        return Math.Abs(prevTemp.TempValue - currentTemp.TempValue);
                    }
                    else
                    {
                        Temperature newCurrentTemp = new Temperature(currentTemp.ConvertedTemperature(prevTemp.TempType.Indicator));
                        return Math.Abs(prevTemp.TempValue - newCurrentTemp.TempValue);
                    }
                }
                else
                    return 0;
            }
        }
    }
}
