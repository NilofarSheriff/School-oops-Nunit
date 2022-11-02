using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    public class Student : Iperson
    {
       public string Name { get; set; }
       public string Class { get ; set; }
        
        

        
        public bool FindStudent(string name)
        {

            List<Student> StudentList = new List<Student>();
            StudentList.Add(new Student { Name = "Nilofar", Class = "12a2b" });
            StudentList.Add(new Student { Name = "Zamruth", Class = "12a2b" });
            StudentList.Add(new Student { Name = "Mehar", Class = "12a2b" });
            StudentList.Add(new Student { Name = "Asif", Class = "12a2b" });
            Student Ans = StudentList.Find(x => x.Name == name);
            if(Ans == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    public class Subject : Iperson 
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string SubjectId { get; set; }
        public List<Subject> SubList { get; set; }

        public bool searchSubjects(string id) {
            List<Subject> Subjectlist = new List<Subject>();
            Subjectlist.Add(new Subject { Name = "Chemistry", SubjectId = "101" });
            Subjectlist.Add(new Subject { Name = "Maths", SubjectId = "102" });
            Subjectlist.Add(new Subject { Name = "Physics", SubjectId = "103" });
            Subjectlist.Add(new Subject { Name = "HR", SubjectId = "104" });
            Subjectlist.Add(new Subject { Name = "EM", SubjectId = "105" });
            Subject found = Subjectlist.Find(x => x.SubjectId == id);
            if(found == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
