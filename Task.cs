using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Person
    {
        public Person(int Age)
        {
            if (Age >= 18)
            {
                IsAdult = true;
            }
            else
            {
                IsAdult = false;
            }
        }

        public string Name;
        public string Surname;
        public int Age;
        public bool IsAdult;

    }
}
