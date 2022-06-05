using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTask
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);
            

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            //var result = classes.SelectMany(c => c.Students).ToArray();
            var result = (from clas in classes
                         from student in clas.Students
                         select student).ToArray();
            return result;
        }
    }
}
