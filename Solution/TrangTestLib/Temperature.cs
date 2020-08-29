using System;
using System.Linq;
using TrangTestLib.DataAccess;

namespace TrangTestLib
{
    public class Temperature
    {
        private TemperatureType tempType;
        private double tempValue;
        private char[] validStringChars = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', 'c', 'C', 'k', 'K', 'f', 'F', ' ', '-', '+' };
        private char[] validTempTypes = { 'c', 'C', 'k', 'K', 'f', 'F' };

        public TemperatureType TempType { get { return tempType; } }
        public double TempValue { get { return tempValue; } }

        /// <summary>
        /// string ctor
        /// </summary>
        /// <param name="_temp">the temperature to convert</param>
        public Temperature(string _temp)
        {
            ValidateInputString(_temp);
            ConvertStringToTemperature(_temp);
        }

        /// <summary>
        /// basic ctor
        /// </summary>
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

        private bool ValidateInputString(string _temp)
        {
            //convert to character array
            char[] stringChars = _temp.ToCharArray();

            // look for the number of characters
            foreach (char c in stringChars)
            {
                // check that the characters are valid
                if (validStringChars.Contains(c))
                {
                    continue;
                }
                else
                {
                    throw new Exception("The entered value contains invalid characters.");
                }
            }
            return true;
        }
        /// <summary>
        /// this method uses the easy method of splitting the string via the space,
        /// left side is the temperature value, right side is the temperature type
        /// </summary>
        /// <param name="_temp">string representation of a temperature</param>
        private void ConvertStringWithSpaceToTemperature(string _temp)
        {
            // split the string 
            string[] values = _temp.Split(' ');
            tempValue = Convert.ToDouble(values[0]);
            tempType = new TemperatureType(values[1]);
        }

        /// <summary>
        /// this method takes a string representation of a temperature and figures out how to convert it to a valid temperature class object
        /// </summary>
        /// <param name="_temp">the string representation of a temperature</param>
        private void ConvertStringToTemperature(string _temp)
        {
            if(_temp.Contains(" "))
            {
                ConvertStringWithSpaceToTemperature(_temp);
            }
            else
            {
                try
                {
                    // find the type of temperature
                    tempType = FindTemperatureType(_temp);
                    // remove the type from the string
                    int indicatorIndex = _temp.ToUpper().IndexOf(tempType.Indicator);
                    string inputValue = _temp.Remove(indicatorIndex, 1);
                    // convert the remainder to the temperature value
                    tempValue = Convert.ToDouble(inputValue);
                }
                catch(Exception x)
                {
                    throw x;
                }
            }
        }

        /// <summary>
        /// this method finds the temperature type from the character in the input string.
        /// </summary>
        /// <param name="_temp">the input string</param>
        /// <returns>a TemperatureType Object</returns>
        private TemperatureType FindTemperatureType(string _temp)
        {
            foreach(char c in _temp)
            {
                if(validTempTypes.Contains(c))
                {
                    return new TemperatureType(c.ToString());
                }
            }
            throw new Exception("No valid temperature type was found in the input string.");
        }
    }
}
