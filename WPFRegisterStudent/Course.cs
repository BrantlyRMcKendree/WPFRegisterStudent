using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRegisterStudent
{
    class Course
    {
        public string name = "";
        public bool isRegisteredAlready = false;
        public static int creditHours;

        public Course(string name)
        {
            this.name = name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public bool IsRegisteredAlready()
        {
            return isRegisteredAlready;
        }

        public void SetToRegistered()
        {
            isRegisteredAlready = true; // Makes the course boolean IsRegistered to true for validation.
            creditHours += 3; // Adds credit hours if the user selection passes validation.
        }

        public void RemovedFromRegistered()
        {
            isRegisteredAlready = false;  // Makes the course boolean IsRegistered to false for validation.
            creditHours -= 3;   // Removes credit hours if the user selection passes validation.
        }

        public override string ToString()
        {
            return getName();
        }
    }
}
