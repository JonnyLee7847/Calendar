using System;
using System.Collections.Generic;

namespace Calendar
{
    public class CalendarEntries : List<ICalendarEntry>
     {

        public bool Load(string calendarEntriesFile)
        {
            class ReadFromFile

            static void main()
        {

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\jonod\OneDrive\Documents\100460457\Calendar_StartingSolution\Calendar_StartingSolution\CalendarApplication\bin\Debug\appointments.txt");
            
        }
        

            bool status = true;
            return status;
        }

        public bool Save(string calendarEntriesFile)
        {
            // TODO.  Add your code to save the collection to the file specified in
            //        calendarEntriesFile here.  You can edit the following two 
            //        lines if you wish.
            bool status = true;
            return status;
        }

        // Iterate through the collection, returning the calendar entries that
        // occur on the specified date

        public IEnumerable<ICalendarEntry> GetCalendarEntriesOnDate(DateTime date)
        {
            for (int i = 0; i < this.Count; i++ )
            {
                if (this[i].OccursOnDate(date))
                {
                    yield return this[i];                
                }
            }
        }
    }
}