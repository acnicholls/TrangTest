using System;
using TrangTestLib.DataAccess;

namespace TrangTestLib
{
    public class Temperature
    {
        private TemperatureType tempType;
        private double tempValue;

        public TemperatureType TempType { get { return tempType; } }
        public double TempValue { get { return tempValue; } }

        public Temperature(string _temp)
        {
            // split the string 
            string[] values = _temp.Split(' ');
            tempValue = Convert.ToDouble(values[0]);
            tempType = new TemperatureType(values[1]);
        }

        public Temperature() { }

        /// <summary>
        /// outputs the temperature as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return tempValue.ToString() + " " + tempType.Indicator;
        }

        /// <summary>
        /// outputs the temperature as a string in the desired output type
        /// </summary>
        /// <param name="_typeIndicator"></param>
        /// <returns></returns>
        public string ConvertedTemperature(string _typeIndicator)
        {
            if (tempType.Indicator == _typeIndicator)
                return ToString();
            else
            {
                TemperatureType toType = new TemperatureType(_typeIndicator);
                Temperature toTemp = new Temperature();
                toTemp.tempType = toType;
                toTemp.tempValue = TemperatureConversion.CalculateConvertedTemperatureValue(tempType.Indicator, toType.Indicator, tempValue);
                return toTemp.ToString();
            }
        }


    }
}
