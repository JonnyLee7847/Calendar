using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class recurringAppt
    {

        string _subjectRecurringAppt;
        string _locationRecurringAppt;
        string _frequencyRecurringAppt;
        int _howManyRecurringAppt;
        int _lengthRecurringAppt;
        DateTime _dateRecurringAppt;
        DateTime _startTimeRecurringAppt;


        public recurringAppt()
        {
            _subjectRecurringAppt = string.Empty;
            _locationRecurringAppt = string.Empty;
            _frequencyRecurringAppt = string.Empty;
        }

        public recurringAppt(string subjectRecurringAppt, string locationRecurringAppt, string frequencyRecurringAppt)
        {
            _subjectRecurringAppt = subjectRecurringAppt;
            _locationRecurringAppt = locationRecurringAppt;
            _frequencyRecurringAppt = frequencyRecurringAppt;
        }

        public recurringAppt(int howManyRecurringAppt, int lengthRecurringAppt)
        {
            _howManyRecurringAppt = howManyRecurringAppt;
            _lengthRecurringAppt = lengthRecurringAppt;
        }

        public recurringAppt(DateTime dateRecurringAppt, DateTime startTimeRecurringAppt)
        {
            _dateRecurringAppt = dateRecurringAppt;
            _startTimeRecurringAppt = startTimeRecurringAppt;
        }

        public string subjectRecurringAppt
        {
            get
            {
                return _subjectRecurringAppt;
            }

            set
            {
                _subjectRecurringAppt = value;
            }
        }

        public string locationRecurringAppt
        {
            get
            {
                return _locationRecurringAppt;
            }

            set
            {
                _locationRecurringAppt = value;
            }
        }

        public string frequencyRecurringAppt
        {
            get
            {
                return _frequencyRecurringAppt;
            }

            set
            {
                _frequencyRecurringAppt = value;
            }
        }


        public int howManyRecurringAppt
        {
            get
            {
                return _howManyRecurringAppt;
            }

            set
            {
                _howManyRecurringAppt = value;
            }
        }

        public int lengthRecurringAppt
        {
            get
            {
                return _lengthRecurringAppt;
            }

            set
            {
                _lengthRecurringAppt = value;
            }
        }

        public DateTime dateRecurringAppt
        {
            get
            {
                return _dateRecurringAppt;
            }

            set
            {
                _dateRecurringAppt = value;
            }
        }

        public DateTime startTimeRecurringAppt
        {
            get
            {
                return _startTimeRecurringAppt;
            }

            set
            {
                _startTimeRecurringAppt = value;
            }
        }

  
    }
}
