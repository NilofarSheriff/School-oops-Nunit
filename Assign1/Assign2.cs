using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assign1
{
    internal class Assign2
    {
        internal class RetriveData
        {
            public class Student
            {
                public int StudentID { get; set; }
                public string StudentName { get; set; }
                public int Age { get; set; }
                public string Grade { get; set; }
            }

            static void Main(string[] args)
            {

                string[] lines = File.ReadAllLines(@"D:\NewRepo\copied.txt");

                List<Student> list = new List<Student>();
                foreach (string student in lines)
                {

                    Student stud = new Student();
                    string[] splitdata = student.Split(',');
                    stud.StudentID = Convert.ToInt32(splitdata[0]);
                    stud.StudentName = splitdata[1];
                    stud.Age = Convert.ToInt32(splitdata[2]);
                    stud.Grade = splitdata[3];
                    list.Add(stud);


                }
               
                Console.WriteLine("Student Details");
                Console.WriteLine();
                foreach (var item in list)
                {


                    Console.WriteLine("StudentID   : " + item.StudentID);
                    Console.WriteLine("StudnetName : " + item.StudentName);
                    Console.WriteLine("AGE         : " + item.Age);
                    Console.WriteLine("Grade       : " + item.Grade);
                    Console.WriteLine();

                }


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Sorted List");
                Console.ForegroundColor = ConsoleColor.White;
                var SortedList = list.OrderBy(s => s.StudentName);

                Console.WriteLine();
                foreach (var item in SortedList)
                {


                    Console.WriteLine("StudentID   : " + item.StudentID);
                    Console.WriteLine("StudnetName : " + item.StudentName);
                    Console.WriteLine("Age         : " + item.Age);
                    Console.WriteLine("Grade       : " + item.Grade);
                    Console.WriteLine();

                }
                Console.WriteLine("****************************");
                Console.WriteLine("Enter student name u Need to search");
                string name = Console.ReadLine();

                var search = list.FindAll(f => f.StudentName == name);
                foreach (var item in search)
                {

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("StudentID   : " + item.StudentID);
                    Console.WriteLine("StudnetName : " + item.StudentName);
                    Console.WriteLine("Age         : " + item.Age);
                    Console.WriteLine("Grade       : " + item.Grade);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                }

                Console.ReadLine();
            }

        }
    }
}
