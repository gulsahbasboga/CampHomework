using System;
using System.Collections.Generic;

namespace CampHomeworkDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Students<int, string> students = new Students<int, string>();
            students.Add(1001, "Gülşah Başboğa");
            students.Add(1002, "Mırmır Kedisi");
            students.Add(1003, "Şeftali Kedisi");

            Console.WriteLine("Student's Number: " + students.Items1[0] + " " + "Student's Name: " + students.Items2[0]);
            Console.WriteLine("Student's Number: " + students.Items1[1] + " " + "Student's Name: " + students.Items2[1]);
            Console.WriteLine("Student's Number: " + students.Items1[2] + " " + "Student's Name: " + students.Items2[2]);

        }
    }
}
