using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning1
{
    public class EmployeeManager
    {
        private static List<Employee> myList;
        private int numOfInput; // Number of employees to be added


        

        public EmployeeManager()
        {
            myList = new List<Employee>();    

        }



        #region  Add an employee

        public void StartAddingEmployees()
        {
            WriteProgramInfo(); // Display the program screen
            ReadInput(); // Read the inputs
            AddGivenEmployees();
           
        }


        private void WriteProgramInfo()  //This program displays third welcome screen.
        {
            Console.WriteLine();  // blankline
            Console.WriteLine("+++++++++++++++++Adding of Employees +++++++++++++++++++++++");
            Console.WriteLine("                   and their respecyive salary\n");
            Console.WriteLine();  // blankline
        }


        private void ReadInput()

        {  // Here, the number of iteration given by the user is passed to the variable numOfInput

            numOfInput = ReadInputChoiceIteration(); // Assign the out value (choice) from the method ReadInputChoiceIteration to 
                                                     // the numOfInput

            Console.WriteLine(); // blank line
        }




       





        // This method validates the user input requested at second console prompt and ensures 
        // that the input is above zero (That is the number of iteration is above zero)
        private int ReadInputChoiceIteration()

        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Number of employees to add?:"); //Request for the number of iterations to be done.

                string strInput = Console.ReadLine();  // Read user input given by the user as a string.

                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted.


                if (validNum) // Yes, the string input was converted!
                {
                    if (choice >= 0)   // Check if the converted value is greater than zero.

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string was not converted. Maybe contains non digit numbers!
                {

                    Console.Write("Invalid input, try again!\n"); // Print out in the console window an error message!
                }



            } while (!validNum); // Repeat this operation until !validNum is false.



            return choice;  // Return the value of the out variable



        }



        private void AddGivenEmployees()
        {
            int index;
            Console.WriteLine("---------------------------------------------------");

            for (index = 0; index < numOfInput; index++)   // for loop for the loop iteration
            {

                Console.Write("Please give the emploee no " + (index + 1) + "(to be added)" + ":"); // Request user input

               Employee obj = CreateEmployee();
                myList.Add(obj);
 
            }

            Console.WriteLine("---------------------------------------------------"); // boarderline.
            Console.WriteLine();
            Console.WriteLine("   A total of " + myList.Count + "  employees added to the system");
            Console.WriteLine();  // blankline

        }





        


        public Employee CreateEmployee()
        {
            Console.Write("New employee's name  ");  // Employee name request
            string strName = Console.ReadLine();    //Read name input

            bool nameOfEmpOK = CheckName(strName);
            double empSalary = ReadInputSalary();   //Read salary given by the user


            if (nameOfEmpOK)
            {

                Employee empOb = new Employee(strName, empSalary);
                return empOb;
            }
            else
                return null;   //Otherwise return null


        }



        private bool CheckName(string obj)
        {
            if(obj == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        public static double ReadInputSalary()
        {
            bool validNum = false; // valid number initially set to zero
            double choice = 0.0;  // out variable initally set to zero



            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("The employee's Salary: ");
                string strInput = Console.ReadLine();
                validNum = double.TryParse(strInput, out choice); // Check if the string can be converted


                if (validNum) // Yes, the string input can be converted!
                {
                    if (choice >= 0.0)
                    {
                        validNum = true;  // Then set validNum to be true if the above condition holds.

                    }

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable



        }

        public static List<Employee> GetList()
        {
            return myList;

        }



        #endregion


       








    }
}
