using System.Collections.Generic;

namespace TrangTestLib
{
    /// <summary>
    /// this collection keeps in memory, how many times each alert is raised.
    /// </summary>
    public class AlertsRaised
    {
        private List<int> AlertIds = new List<int>();
        private List<int> TimesRaised = new List<int>();
        private int index;

        /// <summary>
        /// adds one to the times an alert is raised.
        /// </summary>
        /// <param name="_alertId"></param>
        public void AddTimeRasied(int _alertId)
        {
            if (AlertIds.Contains(_alertId))
            {
                index = AlertIds.IndexOf(_alertId);
                TimesRaised[index] += 1;
            }
            else
            {
                AlertIds.Add(_alertId);
                TimesRaised.Add(1);
            }
        }

        /// <summary>
        /// returns the number stored in memory representing the number of times an alert has been shown
        /// </summary>
        /// <param name="_alertId"></param>
        /// <returns></returns>
        public int CheckTimesRaised(int _alertId)
        {
            if (AlertIds.Contains(_alertId))
            {
                index = AlertIds.IndexOf(_alertId);
                return TimesRaised[index];
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// clears the list in memory
        /// </summary>
        public void ClearList()
        {
            AlertIds.Clear();
            TimesRaised.Clear();
        }
    }
}
