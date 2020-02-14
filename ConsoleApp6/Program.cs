using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();
                Console.WriteLine("Student Name:");
                newStudent.Name = Console.ReadLine();

                //Console.WriteLine("Students Grade:");
                //newStudent.Grade = int.Parse(Console.ReadLine());

                Console.WriteLine("Students Birthday:");
                newStudent.Birthday = Console.ReadLine();

                Console.WriteLine("Students Address:");
                newStudent.Address = Console.ReadLine();

                Console.WriteLine("Students Phone Number:");
                newStudent.Phone = (Console.ReadLine());

                students.Add(newStudent);
                Console.WriteLine("Add another y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }
            foreach (var student in students)
            {
                Console.WriteLine("Name:{0}, Birthday:{1}, Address:{2}, Phone Number:{3}", student.Name, student.Birthday, student.Address, student.Phone);
            }
        }
    }
    class Student
    {
        public string Name;
        public string Birthday;
        public string Address;
        public string Phone;
    }
}
