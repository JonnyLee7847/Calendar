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
        
        private newAppt()
        {
            _subjectNewAppt = string.Empty;
            _locationNewAppt = string.Empty; 
            
        }
        
        private newAppt(string subjectNewAppt, string locationNewAppt)
        {
            _subjectNewAppt = subjectNewAppt;
            _locationNewAppt = locationNewAppt;
        }

        private string subjectNewAppt
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

        private string locationNewAppt
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




        private System.Windows.Forms.TextBox dateNewAppt
        {

        }
        private System.Windows.Forms.ComboBox startTimeNewAppt
        {

        }
        private System.Windows.Forms.ComboBox lengthNewAppt(int)
        {

        }
            
    }
}
