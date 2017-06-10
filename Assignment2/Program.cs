using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[5];
            int[] grades = { 50, 90, 98, 44, 79 };
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Enter Student name for position " + i + ": ");
                students[i] = Console.ReadLine();
            }

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(students[i] + ": " + grades[i]);
            }

             Console.Clear();
        }
    }
}
