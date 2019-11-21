using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GradeBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            string student = "0";
            Dictionary<string, int[]> gpa = new Dictionary<string, int[]>();

            Console.WriteLine("Enter a student name or enter 'quit.' ");
            student = Convert.ToString(Console.ReadLine());

            while (student != "quit")
            {
                Console.WriteLine("Enter the students grades seperated by a space.");
                string temp = (Console.ReadLine());
                char[] devider = new char[] { ' ' };
                string[] grade = temp.Split(devider);
                int[] grades = Array.ConvertAll(grade, s => int.Parse(s));
                gpa.Add(student, grades);

                Console.WriteLine("Enter a student name or enter 'quit.' ");
                student = Convert.ToString(Console.ReadLine());
            }

            int sum = 0;
            foreach (var recored in gpa)
            {
                sum = 0;
                int av = 0;
                foreach (int number in recored.Value)
                {
                    sum += number;
                    int divisor = recored.Value.GetLength(0);
                        av = sum / divisor;


                }

                Console.WriteLine("Student: " + recored.Key +
                    "GPA: " + av + ", Highest Grade: " + recored.Value.Max() +
                    ", Lowest Grade " + recored.Value.Min());



            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}