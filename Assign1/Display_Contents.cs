using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    internal class Display_Contents
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\M NILOFAR\assign1\student_details.txt";
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sw = new StreamReader(fs);
            string studnets_details = sw.ReadToEnd();
            Console.WriteLine(studnets_details);
            Console.WriteLine();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine();
            Console.WriteLine("Process completed");
            Console.ReadLine();

        }
    }
}
