using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    class Program
    {    
        /// Bai 2.
        /// <summary>
        /// <param name="args">comment</param>
        /// <returns>comment</returns>
        /// </summary>
        /// <remarks>
        /// comment
        /// </remarks>

        static void Main(string[] args)
        {
            //Bai 1.
            int studentID = 1;
            String studentName = "David Deogre";
            int age = 18;
            char gender = 'M';
            float percent = 75.50f;
            Console.WriteLine($"Student ID: {studentID}");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Percentage: {percent}");

            //Bai 3.
            int english;
            Console.Write("Enter name of student: ");
            string studentName1 = Console.ReadLine();
            Console.Write("Enter marks of maths: ");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks of english: ");
            english = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks of physical: ");
            int physical = Convert.ToInt32(Console.ReadLine());
            Student(studentName1, math, english, physical);


            Console.ReadKey();
        }

        static void Student(String studentName, int math, int english, int physical)
        {
            int constant = 100;
            float percent = 0f;
            percent = ((math + english + physical) * constant) / 300;
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Marks obtaned in Math: {math}");
            Console.WriteLine($"Marks obtaned in English: {english}");
            Console.WriteLine($"Marks obtaned in Physical: {physical}");
            Console.WriteLine($"Percent: {percent}");
        }
    }
}
