using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning1
{
    public class Menu
    {

        private int choosedInput;  // Menu class instance variable



        public void Start()  // Start Menu method.
        {
            int choice = -1;   // set the initial out value to -1.

            while (choice != 0)     //While loop to ensure that this loop terminates if the user input is zero (0).
            {
                WriteMenuText();  // Displays the first Menu.

                choice = ReadInputChoice();  // Read the input to the Main Menu and assign value to variable choice.

                choosedInput = choice;  // The out variable from the method ReadInputChoice() assigned to variable  
                                        // choosedInput.

                CurrentOperationMenu();  // This method displays the current operation choosed

            }

        }


        // This method validates the user input to the Menu and ensures it is within(0-2) inclusive
        private int ReadInputChoice()
        {
            bool validNum = false; // valid number initially set to zero
            int choice = 0;  // out variable initally set to zero

            do                   // The do-while loop to read user input and validate it
            {
                Console.Write("Make your choice: ");  // User input to the Menu choice requested
                string strInput = Console.ReadLine();  // Read user input to the Menu as a string
                validNum = int.TryParse(strInput, out choice); // Check if the string can be converted

                if (validNum) // Yes, the string input can be converted!
                {
                    if ((choice >= 0) && (choice <= 2))  // Check if the converted integer lies within 1 -5 inclusive

                        validNum = true;  // Then set validNum to be true if the above condition holds.

                }
                if (!validNum) // No. The string cannot be converted. Maybe contains non digit numbers.
                {
                    Console.WriteLine("Invalid input, try again!\n");   // Print out in the console window an error message!
                }

            } while (!validNum); // Repeat this operation until !validNum is false.

            return choice;  // Return the value of the out variable

        }



        private void WriteMenuText()  // This method displays the first main Menu.

        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("                  MAIN MENU                   ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("     Add an employee                         :1");
            Console.WriteLine("     Show all employees and their salaries   :2");
            Console.WriteLine("     Exit the program                        :0");
            Console.WriteLine("----------------------------------------------");



        }

        private void AddEmployee()
        {
            Console.Title = "Add and employee and salary"; // console window title

            Console.WriteLine();

            EmployeeManager emploMgr = new EmployeeManager();
            emploMgr.StartAddingEmployees();



        }

        





        private void ShowAllEmployees()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" List of Employees and Salaries ");


            foreach (var emp in EmployeeManager.GetList())
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("-------------------------------");

        }



        





        private void CurrentOperationMenu()    // All the operations for this Application is selected here
        {
            switch (choosedInput)   // The switch block used the choosedInput as variable for the check.
            {
                case 1:
                    AddEmployee();  // Call this method to add employee for case 1
                    break;

                case 2:
                    ShowAllEmployees(); // Call this method to show all employees for case 2
                    break;

                case 0:
                    Environment.Exit(0); // Call this to exit program.
                    break;

                default:
                    Console.WriteLine("Wrong choice try again!");
                    break;

            }

        }








    }
}
