using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class newRecAppt
    {

        string _subjectRecAppt;
        string _locationRecAppt;

        private newRecAppt()
        {
            _subjectRecAppt = string.Empty;
            _locationRecAppt = string.Empty;
        }

        private newRecAppt(string subjectRecAppt, string locationRecAppt)
        {
            _subjectRecAppt = subjectRecAppt;
            _locationRecAppt = locationRecAppt;
        }

        private string subjectRecAppt
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

        private string locationRecAppt
        {
            get
            {
                return _locationRecAppt;
            }

            set
            {
                _locationRecAppt = value;
            }








        private System.Windows.Forms.TextBox dateRecAppt
        {

        }
        private System.Windows.Forms.ComboBox startTimeRecAppt
        {

        }
        private System.Windows.Forms.ComboBox lengthRecAppt
        { 
        
        }
        private System.Windows.Forms.ComboBox frequencyRecAppt
        {

        }
        private System.Windows.Forms.TextBox howManyRecAppt(int)
        {

        }

        
    }
}
