using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.College
{
    internal class Student:Attributes
    {
        private string[] _courses = { };
        public string[] Courses => _courses;
        public Student(int id, string name) : base(id,name)
        {
        }

        public void SetCourses(string[] courses) => _courses = courses;
    }
}
