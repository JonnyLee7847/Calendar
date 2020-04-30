using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class newAppt
    {

        string _subjectNewAppt;
        string _locationNewAppt;
        int _lengthNewAppt;
        DateTime _dateNewAppt;
        DateTime _startTimeNewAppt;


        public newAppt()
        {
            _subjectNewAppt = string.Empty;
            _locationNewAppt = string.Empty; 
            
        }
        
        public newAppt(string subjectNewAppt, string locationNewAppt)
        {
            _subjectNewAppt = subjectNewAppt;
            _locationNewAppt = locationNewAppt;
        }

        public newAppt(int lengthNewAppt)
        {
            _lengthNewAppt = lengthNewAppt;
        }

        public newAppt(DateTime dateNewAppt, DateTime startTimeNewAppt)
        {
            dateNewAppt = _dateNewAppt;
            startTimeNewAppt = _startTimeNewAppt;
        }



        public string subjectNewAppt
        {
            get
            {
                return _subjectNewAppt;
            }

            set
            {
                _subjectNewAppt = value;
            }
        }

        public string locationNewAppt
        {
            get
            {
                return _locationNewAppt;
            }

            set
            {
                _locationNewAppt = value;
            }

        }

        public int lengthNewAppt
        {
            get
            {
                return _lengthNewAppt;
            }

            set
            {
                _lengthNewAppt = value; 
            }
        }


        public DateTime dateNewAppt
        {
            get
            {
                return _dateNewAppt;
            }

            set
            {
                _dateNewAppt = value;
            }
        }
            
        public DateTime startTimeNewAppt
        {
            get
            {
                return _startTimeNewAppt;
            }

            set
            {
                _startTimeNewAppt = value;
            }
        }
        
        
            
    }
}
