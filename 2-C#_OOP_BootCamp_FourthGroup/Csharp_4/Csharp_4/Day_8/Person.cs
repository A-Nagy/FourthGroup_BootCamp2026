using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_8
{
    abstract class Person
    {
        public string Name { get; set; }
        public Person(string name )
        {
            Name = name;   
        }

        public abstract string PrintAllData();
       
    }
}
