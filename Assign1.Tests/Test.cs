using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assign1;

namespace Assign1.Tests
{
    [TestFixture]
    public class Test
    {
        Student s1 = new Student();
        [TestCase("Nilofar",ExpectedResult =true)]
        [TestCase("Asif", ExpectedResult = true)]
        [TestCase("Varshini", ExpectedResult = false)]
        public bool searchstudent(string name)
        {
            bool ans=s1.FindStudent(name);
            return ans;

        }

        Teacher T1 = new Teacher();
        [TestCase("Hema", ExpectedResult = true)]
        [TestCase("Shiny", ExpectedResult = true)]
        [TestCase("VarSathya", ExpectedResult = false)]
        public bool SearchTeacher(string name)
        {
            bool ans = T1.searchTeacher(name);
            return ans;
        }

        Subject sub = new Subject();
        [TestCase("101", ExpectedResult = true)]
        [TestCase("103", ExpectedResult = true)]
        [TestCase("110", ExpectedResult = false)]
        [TestCase("107", ExpectedResult = false)]
        public bool searchsubject(string id)
        {
            bool ans=sub.searchSubjects(id);
            return ans;
        }

    }
}
