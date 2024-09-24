using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.College
{
    internal class Course : Attributes
    {
        public string[] Teacher_Id {  get; set; }
        public string[] Student_Id { get; set; }

        public Course(int id, string name) :base(id, name)
        {
        }
    }
}
