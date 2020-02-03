using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTaskList
{

    class Duties
    {   //fields
        private string employee;
        private string duty;
        private DateTime dueDate;
        private bool complete;

        //properties
        public string Employee
        {
            get { return employee; }
            set { employee = value; }
        }

        public string Duty
        {
            get { return duty; }
            set { duty = value; }
        }

        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        public bool Complete
        {
            get { return complete; }
            set { complete = value; }
        }
        public Duties()
        {

        }
        //overloaded constructors
        public Duties(string _employee, string _duty, DateTime _dueDate)
        {
            employee = _employee;
            duty = _duty;
            dueDate = _dueDate;
        }


    }
}

