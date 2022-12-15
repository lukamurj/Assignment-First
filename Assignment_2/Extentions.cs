using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal static class Extentions
    {
        public static void PrintStudentsList(this List<Student> students)
        {
            for(var i = 0; i < students.Count; i++)
            {
                Console.WriteLine(i + 1 + ". Student's full name is " + students[i].FirstName + " " + students[i].LastName);
            }
        }
    }
}
