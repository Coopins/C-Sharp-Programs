using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ToDoItem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> List = new Dictionary<string, DateTime>();

            Console.WriteLine("Enter a To Do Item name or enter 'quit'.");
            string ToDo = Convert.ToString(Console.ReadLine());
            ToDoItem one = new ToDoItem();
            one.Description = "0";
            one.DueDate = new DateTime(2000, 1, 1);
            one.Priority = 1;
            string priority = "Low Priority";

            while (ToDo != "quit")
            {
                Console.WriteLine("Enter the due date in format MM/DD/YYYY: ");
                try
                {
                    one.DueDate = DateTime.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Please enter in the correct format, " +
                        "MM/DD/YYYY: ");
                    continue;
                }
                Console.WriteLine("Enter Priority level; 1 for low, " +
                    "2 for medium & 3 for high.");

                try
                {
                    one.Priority = Convert.ToInt32(Console.ReadLine());

                }

                catch
                {
                    one.Priority = 1;
                    Console.WriteLine("Priority has been set to low because you " +
                        "Failed to follow instructions.");


                }
                if (one.Priority == 1)
                {
                    priority = "Low Priority";

                }
              else if (one.Priority == 2)
                {
                    priority = "Medium Priority";

                }
                else if (one.Priority == 3)
                {
                    priority = "High Priority";

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Let's try this again.");
                
                }

                one.Description = priority + ":    >" + ToDo;
                List.Add(one.Description, one.DueDate);

                Console.WriteLine("Enter a To Do Item name or enter 'quit.' ");
                ToDo = Convert.ToString(Console.ReadLine());



            }

            foreach (KeyValuePair<string, DateTime> item in List)
            {
                string due = item.Value.ToString("d");

                Console.WriteLine("Due by {0}:    {1}", due, item.Key);
            }

            Console.ReadKey();
        }

    }

    public class ToDoItem

    {
        public string Description;
        public DateTime DueDate;
        public int Priority;
    }
}


           