using System.Linq;

namespace TrangTestLib.DataAccess
{
    public class TemperatureType
    {
        private int id;
        private string name;
        private string indicator;

        public int Id { get { return id; } }
        public string Name {  get { return name; } }
        public string Indicator {  get { return indicator; } }

        /// <summary>
        /// indicator string ctor
        /// </summary>
        /// <param name="_indicator">the temperature indicator value in string format</param>
        public TemperatureType(string _indicator)
        {

            Data.TrangTest.TemperatureTypesRow typeRow = Data.XMLOperations.ReadXML().TemperatureTypes.First(tt => tt.TempType_Indicator == _indicator.ToUpper());
            id = typeRow.TempType_ID;
            name = typeRow.TempType_Name;
            indicator = typeRow.TempType_Indicator;
        }

        /// <summary>
        /// row id ctor
        /// </summary>
        /// <param name="_id">the ID of the row in the database</param>
        public TemperatureType(int _id)
        {
            Data.TrangTest.TemperatureTypesRow typeRow = Data.XMLOperations.ReadXML().TemperatureTypes.First(tt => tt.TempType_ID == _id);
            id = typeRow.TempType_ID;
            name = typeRow.TempType_Name;
            indicator = typeRow.TempType_Indicator;
        }
    }
}
