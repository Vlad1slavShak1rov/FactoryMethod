using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.College
{
    internal class Teacher :Attributes
    {
        private int _experience = 0; 
        public int Experience => _experience;
        private string[] _courses = { };
        public string[] Courses => _courses;
        public Teacher(int id, string name) :base(id, name)
        {
        }
        public void SetExperience(int experience) => _experience = experience;
        public void SetCourses(string[] courses) => _courses = courses;
     
    }
}
