using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    internal class Write_Contents
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\M NILOFAR\assign1\student_details.txt";
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("\n\nName:Nilofar\n age:21\n Grade:O" +
                "\n\n Name:Zamruth\n age:20\n Grade:A+\n\n Name:Mehar\n age:19\n Grade:A\n\n Name:Asif\n age:21\n Grade:O\n\nName:Varshini\n age:21\n Grade:O\n\n" +
                "Name:Israth\n age:21\n Grade:O\n\n");

            sw.Close();
            sw.Dispose();

            Console.WriteLine("Process completed");
            Console.ReadLine();
        }
    }
}
