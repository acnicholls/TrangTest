using System.Linq;

namespace TrangTestLib.DataAccess
{
    public class TemperatureThreshold
    {
        private int id;
        private string name;
        private int typeId;
        private double temp;

        public int Id { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public int TypeId { get { return typeId; } set { typeId = value; } }
        public double Temperature {  get { return temp; } set { temp = value; } }

        /// <summary>
        /// basic ctor
        /// </summary>
        public TemperatureThreshold()
        {
            id = 0;
        }

        /// <summary>
        /// database row id ctor
        /// </summary>
        /// <param name="_id"></param>
        public TemperatureThreshold(int _id)
        {
            Data.TrangTest.TemperatureThresholdsRow threshRow = Data.XMLOperations.ReadXML().TemperatureThresholds.First(tt => tt.TempThreshold_ID == _id);
            if (threshRow != null)
            {
                id = threshRow.TempThreshold_ID;
                name = threshRow.TempThreshold_Name;
                typeId = threshRow.TempThreshold_TypeID;
                temp = threshRow.TempThreshold_Value;
            }
        }

        /// <summary>
        /// this method will save the current object to the database
        /// </summary>
        public void Save()
        {
            Data.TrangTest ds = Data.XMLOperations.ReadXML();
            // define a new threshold row
            Data.TrangTest.TemperatureThresholdsRow threshRow;
            // are we updating the row or adding a new one?
            threshRow = ds.TemperatureThresholds.NewTemperatureThresholdsRow();
            // add or update all the values the user can change
            threshRow.TempThreshold_Name = name;
            threshRow.TempThreshold_TypeID = typeId;
            threshRow.TempThreshold_Value = temp;
            // now save the new threshold to the database
            ds.TemperatureThresholds.AddTemperatureThresholdsRow(threshRow);
            ds.AcceptChanges();
            Data.XMLOperations.WriteXML(ds);
            if(id < 1)
                id = threshRow.TempThreshold_ID;
        }

        /// <summary>
        /// this method will udpate the current object in the database
        /// </summary>
        public void Update()
        {
            Data.TrangTest ds = Data.XMLOperations.ReadXML();
            // define a new threshold row
            Data.TrangTest.TemperatureThresholdsRow threshRow = ds.TemperatureThresholds.First(tt => tt.TempThreshold_ID == id);
            // add or update all the values the user can change
            threshRow.TempThreshold_Name = name;
            threshRow.TempThreshold_TypeID = typeId;
            threshRow.TempThreshold_Value = temp;
            // now save the new threshold to the database
            ds.AcceptChanges();
            Data.XMLOperations.WriteXML(ds);
        }

    }
}
