using System.IO;
using System.Reflection;

namespace TrangTestLib.Data
{
    public class XMLOperations
    {
        private static string location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static string filename = "TrangTest.xml";

        private static string fileLocation = Path.Combine(location, "Data", filename);

        /// <summary>
        /// reads the XML file containing data and loads it into a dataset for comsumption by the application
        /// </summary>
        /// <returns>TrangTest DataSet</returns>
        public static TrangTest ReadXML()
        {
            TrangTest returnValue = new TrangTest();
            FileStream defaultData = new FileStream(fileLocation, FileMode.Open, FileAccess.Read, FileShare.Read);
            returnValue.Clear();
            returnValue.ReadXml(defaultData);
            defaultData.Close();
            return returnValue;
        }

        /// <summary>
        /// merges the changed data from the input dataset and writes it out to file
        /// </summary>
        /// <param name="_dataToWrite">data with changes</param>
        public static void WriteXML(TrangTest _dataToWrite)
        {
            _dataToWrite.WriteXml(fileLocation);
        }


    }
}
