using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExperts
{
    class Validator
    {
        private static string title = "Entry Error";
        //The title that will appear in dialog boxes.
        public static string Title
        {
            get { return title; }
            set { title = value; }
        }
        //Checks whether the user entered data into a text box.
        public static bool IsPresent(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(textBox.Tag + " is a required field.", Title);
                    textBox.Focus();
                    return false;
                }
            }

            return true;
        }

        //check if the string is an int
        public static bool inputIsInteger(string input, out string msg)
        {
            int value;
            msg = "";
            if (int.TryParse(input, out value))
            { //input is an integer
                return true;
            }
            //input is not an integer
            msg = "Please use whole numbers";
            return false;
        }
        //check if  min <= input <= max
        public static bool inputRangeIsValid(int input, int min, int max, out string msg)
        {
            if (input >= min && input <= max) //input is in range
            {
                msg = "";
                return true;
            }
            //input is out of range
            msg = "Please use numbers between "+min +" and "+ max;
            return false;
        }
        //checks if string is not empty
        public static bool notEmpty(string input, out string msg)
        {

            if (input.Length != 0 && input.Trim().Length != 0)//input is not empty
            {
                msg = "";
                return true;
            }
            //input is empty
            msg = "Please dont leave this field blank";
            return false;
        }

        
    }
}
