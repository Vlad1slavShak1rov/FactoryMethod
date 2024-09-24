using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.College;
namespace FactoryMethod.FactoryMethod
{
    public abstract class FactoryMethod
    {
        public static Attributes FabrickMethod(string line)
        {
            string[] param = line.Split(',');   
            int id = int.Parse(param[1]);
            string name  = param[2];
            
            if (param[0].ToLower() == "teacher")
            {
                return new Teacher(id, name);
            }
            if (param[0].ToLower() == "student")
            {
                return new Student(id, name);
            }
            if (param[0].ToLower() == "course")
            {
                return new Course(id, name);
            }
            return null;
        }
    }
}
