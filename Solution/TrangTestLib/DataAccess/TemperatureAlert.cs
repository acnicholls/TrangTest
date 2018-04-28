using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrangTestLib.DataAccess
{
    public class TemperatureAlert
    {
        private int id;
        private TemperatureThreshold threshold;
        private string direction;
        private double minFlucuation;
        private string times;
        private string message;

        public int Id { get { return id; } }
        public TemperatureThreshold Threshold { get { return threshold; } set { threshold = value; } }
        public string Direction { get { return direction; } set { direction = value; } }
        public double MinimumFlucuation { get { return minFlucuation; }set { minFlucuation = value; } }
        public string Times { get { return times; }set { times = value; } }
        public string Message { get { return message; } set { message = value; } }

        public TemperatureAlert()
        {
            id = 0;
            threshold = new TemperatureThreshold();
        }

        public TemperatureAlert(int _id)
        {
            Data.TrangTest.TemperatureAlertsRow alertRow = Data.XMLOperations.ReadXML().TemperatureAlerts.First(ta => ta.TempAlert_ID == _id);
            if(alertRow != null)
            {
                id = alertRow.TempAlert_ID;
                threshold = new TemperatureThreshold(alertRow.TempAlert_ThresholdID);
                direction = alertRow.TempAlert_Direction;
                minFlucuation = alertRow.TempAlert_MinFluctuation;
                times = alertRow.TempAlert_Times;
                message = alertRow.TempAlert_Message;
            }
        }

        public void Save()
        {
            threshold.Save();
            Data.TrangTest ds = Data.XMLOperations.ReadXML();
            Data.TrangTest.TemperatureAlertsRow alertRow;
            alertRow = ds.TemperatureAlerts.NewTemperatureAlertsRow();
            // add the other column info
            alertRow.TempAlert_Direction = direction;
            alertRow.TempAlert_MinFluctuation = minFlucuation;
            alertRow.TempAlert_ThresholdID = threshold.Id;
            alertRow.TempAlert_Times = times;
            alertRow.TempAlert_Message = message;
            // now add it to the dataset
            ds.TemperatureAlerts.AddTemperatureAlertsRow(alertRow);
            ds.AcceptChanges();
            Data.XMLOperations.WriteXML(ds);
            // grab the ID
            if (id < 1)
                id = alertRow.TempAlert_ID;
        }

        public void Update()
        {
            threshold.Update();
            Data.TrangTest ds = Data.XMLOperations.ReadXML();
            Data.TrangTest.TemperatureAlertsRow alertRow = ds.TemperatureAlerts.First(ta => ta.TempAlert_ID == id);
            // update the remainder of the information
            alertRow.TempAlert_Direction = direction;
            alertRow.TempAlert_MinFluctuation = minFlucuation;
            alertRow.TempAlert_ThresholdID = threshold.Id;
            alertRow.TempAlert_Times = times;
            alertRow.TempAlert_Message = message;
            // now add it to the dataset
            ds.AcceptChanges();
            Data.XMLOperations.WriteXML(ds);
        }

    }
}
