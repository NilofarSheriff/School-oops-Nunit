using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
   public class Iperson
    {
        string Name { get; set; }
        string Class { get; set; }
    }
    public class Teacher : Iperson
    {
        public string Name { get; set; }
        public string Class { get; set; }

        public string Subject { get; set; }

        public List<Teacher> StudentList { get; set; }

        public bool searchTeacher(string Name)
        {
            List<Teacher> TeachersList = new List<Teacher>();
            TeachersList.Add(new Teacher { Name = "SahayaMary", Class = "12a2b", Subject = "Chemistry"});
            TeachersList.Add(new Teacher { Name = "Sivaprakasam", Class = "EEE", Subject = "EM2" });
            TeachersList.Add(new Teacher { Name = "Hema", Class = "EEE", Subject = "HR" });
            TeachersList.Add(new Teacher { Name = "Vasanthi", Class = "12a2b", Subject = "Biology" });
            TeachersList.Add(new Teacher { Name = "Shiny", Class = "12a2b", Subject = "Maths" });
            Teacher found = TeachersList.Find(x => x.Name == Name);
            if(found != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
