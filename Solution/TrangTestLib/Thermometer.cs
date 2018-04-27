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

        public Thermometer()
        {
            this.RaiseAlert += Thermometer_RaiseAlert;
        }


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

                if(!TempValueMatchCheck(val1, val2))
                {
                    if(CheckAlertCriteria(tr.TempThreshold_ID, out alertId))
                    {
                        AlertEventArgs args = new AlertEventArgs();
                        args.AlertId = alertId;
                        RaiseAlert(this, args);
                    }
                }

            }

            // invoke the callers output method
            OutputEventArgs outputArgs = new OutputEventArgs();
            outputArgs.InputTemp = currentTemp;
            OutputTemps(this, outputArgs);
        }

        private bool TempValueMatchCheck(double _val1, double _val2)
        {
            if (_val1 == _val2)
                return true;
            else
                return false;
        }

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

                bool timesCheck = false;
                // check that we haven't already alerted the user more than the allowed times
                returnValue = fluxCheck & dirCheck & timesCheck;
                if(returnValue)
                {
                    _alertId = aRow.TempAlert_ID;
                    break;
                }
            }
            return returnValue;
        }

        private bool FlucuationCheck(double _minFlux)
        {
            double checkValue = ChangeAmount;
            if (checkValue < 0)
                checkValue = checkValue * -1;
            return checkValue > _minFlux;
        }

        private bool DirectionCheck(string _direction)
        {
            string dir = CheckDirectionOfChange;
            if (dir != "N")
                return dir == _direction;
            else
                return false;
        }

        private bool TimesCheck(int _alertId, string _timesAllowed)
        {
            int allowed = 0;
            if (_timesAllowed == "O")
                allowed = 1;
            return allowed == 0 | NumberOfAlerts.CheckTimesRaised(_alertId) == 0;
        }

        private string CheckDirectionOfChange
        {
            get
            {
                if(prevTemp.TempType.Indicator == currentTemp.TempType.Indicator)
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
        }

        private double ChangeAmount
        {
            get
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
        }
    }
}
