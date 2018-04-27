using System.Linq;
using Microsoft.JScript;

namespace TrangTestLib.DataAccess
{
    public class TemperatureConversion
    {
        private int id;
        private int typeId_from;
        private int typeId_to;
        private string formula;

        //public int Id { get { return id; } }
        //public int TypeId_From { get { return typeId_from; } }
        //public int TypeId_To {  get { return typeId_to; } }
        //public string Formula { get { return formula; } }

        /// <summary>
        /// finds a row in the XML data that matches the specific conversion formula
        /// </summary>
        /// <param name="_fromType">the type of temperature value to be converted</param>
        /// <param name="_toType">the type of temperatore to convert the value to</param>
        public TemperatureConversion(int _fromType, int _toType)
        {
            Data.TrangTest.TemperatureConversionsRow convRow = Data.XMLOperations.ReadXML().TemperatureConversions.First(tc => tc.TempCon_From_TypeID == _fromType & tc.TempCon_To_TypeID == _toType);
            if (convRow != null)
            {
                id = convRow.TempCon_ID;
                typeId_from = convRow.TempCon_From_TypeID;
                typeId_to = convRow.TempCon_To_TypeID;
                formula = convRow.TempCon_Formula;
            }
        }

        /// <summary>
        /// unique function to get the conversion formula to use to calculate the new value
        /// </summary>
        /// <param name="_fromTypeId">the integer ID value of the temperature type to convert from</param>
        /// <param name="_toTypeId">the integer ID value of the temperature type to convert to</param>
        /// <returns></returns>
        private static string ConversionFormula(int _fromTypeId, int _toTypeId)
        {
            TemperatureConversion conversion = new TemperatureConversion(_fromTypeId, _toTypeId);
            if (conversion != null)
                return conversion.formula;
            else
                return null;
        }

        /// <summary>
        /// an override that uses the string characters of the temperature types to find the conversion formula
        /// </summary>
        /// <param name="_fromTypeIndicator">the one character indicator of the temperature being converted from</param>
        /// <param name="_toTypeIndicator">the one character indicator of the temperature to convert the value to</param>
        /// <returns></returns>
        private static string ConversionFormula(string _fromTypeIndicator, string _toTypeIndicator)
        {
            TemperatureType fromType = new TemperatureType(_fromTypeIndicator);
            TemperatureType toType = new TemperatureType(_toTypeIndicator);
            return ConversionFormula(fromType.Id, toType.Id);
        }

        /// <summary>
        /// calculates the value of the passed in temperature to the passed in type
        /// </summary>
        /// <param name="_from">the type of temperature being converted</param>
        /// <param name="_to">the type of temperature being converted to</param>
        /// <param name="temperature">the value of the temperature</param>
        /// <returns></returns>
        public static double CalculateConvertedTemperatureValue(string _from, string _to, double temperature)
        {
            Microsoft.JScript.Vsa.VsaEngine calcEngine = Microsoft.JScript.Vsa.VsaEngine.CreateEngine();
            string formula = string.Format(ConversionFormula(_from, _to), temperature);
            object result = Eval.JScriptEvaluate(formula, calcEngine);
            return Convert.ToNumber(result);
        }

    }
}
