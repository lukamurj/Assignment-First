using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Interface<Person> interFace = new InterfaceImplementation();
            Name name = new("Luka", "Murjikneli");
            Console.WriteLine(interFace.CreateStudentsList(name).FirstName);
            Console.WriteLine();

            var result = interFace.GetStudentsList();

            foreach (var item in result)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            Console.WriteLine();

            var result_2 = interFace.GetStudentsListSortedBy(result, "Giorgi");

            foreach (var item in result_2)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
            Console.WriteLine();

            List<Person> person = new List<Person>();

            foreach (var item in result)
            {
                person.Add(new Student(item.FirstName, item.LastName));
            }

            var result_3 = interFace.GetStudentsListSorted(person);

            foreach (var item in result_3)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            List<Student> students = new();

            foreach (var item in result)
            {
                students.Add(new Student(item.FirstName, item.LastName));
            }

            students.PrintStudentsList();

            Console.ReadKey();
        }
    }
}
