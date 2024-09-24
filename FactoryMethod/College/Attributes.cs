using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.College
{
    public abstract class Attributes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Attributes(int id, string name) 
        {
            Name = name;
            Id = id;
        }
    }
}
