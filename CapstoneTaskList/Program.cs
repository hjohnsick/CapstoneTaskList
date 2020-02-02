using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CapstoneTaskList
{
    class Program
    {
        static void Main(string[] args)

        {
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
            }
            

            Console.WriteLine("Welcome To The Task Manager!");

            //Menu user will select from 
            List<string> taskList = new List<string>
            {"\t1.  List Tasks", "\t2.  Add Task", "\t3.  Delete Task", "\t4.  Mark Task Complete",
            "\t5.  Quit" 
            };

            //list of tasks
            List<Duties> displayTasks = new List<Duties>
            {
                new Duties ("Edward", "trim hedges", DateTime.Parse("06/20/2020")),
                new Duties ("Terry", "clean pool", DateTime.Parse("05/13/2020")),
                new Duties ("Stephanie", "clean gutters", DateTime.Parse("03/13/2020")),
            };

            //to repeat the prompts
            bool repeat = true;

            while (repeat)
            {
                //prints task list to screen
                foreach (string item in taskList)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"\nEnter the number for the task you wish to complete: ");
                string input = Console.ReadLine();

                //if user input is 1, it will display the task list
                if (input == "1")
                {
                    PrintList(displayTasks);
                }
                //if user input is 2, it will prompt user to enter info
                else if (input == "2")
                {
                    Console.WriteLine("\nEnter a name: ");
                    string employee = Console.ReadLine();
                    Console.WriteLine("\nEnter a task description: ");
                    string duty = Console.ReadLine();
                    Console.WriteLine("\nEnter a date in this format mm/dd/yyyy: ");
                    string dueDate = Console.ReadLine();

                    //inputs into display tasks list
                    displayTasks.Add(new Duties(employee, duty, DateTime.Parse(dueDate)));

                    Console.WriteLine("\nNew task was added.");
                }
                //delete task.  I couldn't figure out how to validate if the number entered is in range-prompt to enter a number in range
                else if (input == "3")
                {
                    PrintList(displayTasks);
                    Console.WriteLine("\nWhat task do you want to delete?: ");
                    int index = int.Parse(Console.ReadLine());
                    displayTasks.RemoveAt(index - 1);

                    Console.WriteLine($"Task {index} was removed. ");
                }
                //mark task complete
                else if (input == "4")
                {
                    Console.WriteLine("\nWhat task do you want to mark complete?: ");
                    PrintList(displayTasks);

                    int index = int.Parse(Console.ReadLine());

                    displayTasks[index - 1].Complete = true;
                }
                else if (input == "5")
                {
                    Console.WriteLine("\nGood Bye!");
                    break;
                }
                Console.WriteLine("\nWould you like to return to the main menu? Please enter y/n");
                if (Console.ReadLine().ToLower() == "n")
                {
                    Console.WriteLine("\nGood Bye!");
                    repeat = false;
                }
            }
        }


      
        //Method to print display tasks
        public static void PrintList (List<Duties> taskList)
        {
            for (int i = 0; i < taskList.Count; i++)//have to input the fields from the duties class
            {
                Console.WriteLine();
                Console.WriteLine((i + 1) + ":");
                Console.WriteLine($"\t{taskList[i].Employee}");
                Console.WriteLine($"\t{taskList[i].DueDate}");
                Console.WriteLine($"\t{taskList[i].Duty}");
                Console.WriteLine(taskList[i].Complete == true ? "\tCompleted" : "\tNot Completed");
                Console.WriteLine();

            }
        }
    }
}