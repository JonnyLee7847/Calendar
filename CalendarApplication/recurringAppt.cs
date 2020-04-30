using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class recurringAppt
    {

        string _subjectRecAppt;
        string _locationRecAppt;
        string _frequencyRecAppt;
        int _howManyRecAppt;
        int _lengthRecAppt;
        DateTime _dateRecAppt;
        DateTime _startTimeRecAppt;


        public recurringAppt()
        {
            _subjectRecAppt = string.Empty;
            _locationRecAppt = string.Empty;
            _frequencyRecAppt = string.Empty;
        }

        public recurringAppt(string subjectRecAppt, string locationRecAppt, string frequencyRecAppt)
        {
            _subjectRecAppt = subjectRecAppt;
            _locationRecAppt = locationRecAppt;
            _frequencyRecAppt = frequencyRecAppt;
        }

        public recurringAppt(int howManyRecAppt, int lengthRecAppt)
        {
            _howManyRecAppt = howManyRecAppt;
            _lengthRecAppt = lengthRecAppt;
        }

        public recurringAppt(DateTime dateRecAppt, DateTime startTimeRecAppt)
        {
            _dateRecAppt = dateRecAppt;
            _startTimeRecAppt = startTimeRecAppt;
        }

        public string subjectRecAppt
        {
            get
            {
                return _subjectRecAppt;
            }

            set
            {
                _subjectRecAppt = value;
            }
        }

        public string locationRecAppt
        {
            get
            {
                return _locationRecAppt;
            }

            set
            {
                _locationRecAppt = value;
            }
        }

        public string frequencyRecAppt
        {
            get
            {
                return _frequencyRecAppt;
            }

            set
            {
                _frequencyRecAppt = value;
            }
        }


        public int howManyRecAppt
        {
            get
            {
                return _howManyRecAppt;
            }

            set
            {
                _howManyRecAppt = value;
            }
        }

        public int lengthRecAppt
        {
            get
            {
                return _lengthRecAppt;
            }

            set
            {
                _lengthRecAppt = value;
            }
        }

        public DateTime dateRecAppt
        {
            get
            {
                return _dateRecAppt;
            }

            set
            {
                _dateRecAppt = value;
            }
        }

        public DateTime startTimeRecAppt
        {
            get
            {
                return _startTimeRecAppt;
            }

            set
            {
                _startTimeRecAppt = value;
            }
        }

  
    }
}
