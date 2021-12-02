using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning1
{
     public class Employee
    {
        //Private fields
        private string name;
        private double salary;
       

        //Contructor
        public Employee( string name, double salary)
        {
            Name = name;
            Salary = salary;

        }

       


        public string Name        //Property of the name
        {
            get { return name; }

            set
            {
                name = value;
            }

        }

        public double Salary        //Property of the salary
        {
            get { return salary; }

            set
            {
                salary = value;
            }

        }


        public override string ToString()
        {
            return $" Name : {Name}   Salary: {Salary}";
        }




    }
}
