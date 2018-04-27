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
        private int thresholdId;
        private string direction;
        private double minFlucuation;
        private string times;
        private string message;

        public int Id { get { return id; } }
        public int ThresholdId { get { return thresholdId; } set { thresholdId = value; } }
        public string Direction { get { return direction; } set { direction = value; } }
        public double MinimumFlucuation { get { return minFlucuation; }set { minFlucuation = value; } }
        public string Times { get { return times; }set { times = value; } }
        public string Message { get { return message; } set { message = value; } }

        public TemperatureAlert()
        {
            id = 0;
        }

        public TemperatureAlert(int _id)
        {
            Data.TrangTest.TemperatureAlertsRow alertRow = Data.XMLOperations.ReadXML().TemperatureAlerts.First(ta => ta.TempAlert_ID == _id);
            if(alertRow != null)
            {
                id = alertRow.TempAlert_ID;
                thresholdId = alertRow.TempAlert_ThresholdID;
                direction = alertRow.TempAlert_Direction;
                minFlucuation = alertRow.TempAlert_MinFluctuation;
                times = alertRow.TempAlert_Times;
                message = alertRow.TempAlert_Message;
            }
        }

        public void Save()
        {
            Data.TrangTest.TemperatureAlertsRow alertRow;
            if(id > 0)
            {
                alertRow = Data.XMLOperations.ReadXML().TemperatureAlerts.First(ta => ta.TempAlert_ID == id);
            }
            else
            {
                alertRow = Data.XMLOperations.ReadXML().TemperatureAlerts.NewTemperatureAlertsRow();
                int maxId = Data.XMLOperations.ReadXML().TemperatureAlerts.Max(ta => ta.TempAlert_ID);
                alertRow.TempAlert_ID = maxId + 1;
            }
            alertRow.TempAlert_Direction = direction;
            alertRow.TempAlert_MinFluctuation = minFlucuation;
            alertRow.TempAlert_ThresholdID = thresholdId;
            alertRow.TempAlert_Times = times;
            alertRow.TempAlert_Message = message;
            alertRow.AcceptChanges();
            // now add it to the dataset
            Data.TrangTest ds = Data.XMLOperations.ReadXML();
            ds.TemperatureAlerts.ImportRow(alertRow);
            ds.AcceptChanges();
            Data.XMLOperations.WriteXML(ds);
        }

    }
}
