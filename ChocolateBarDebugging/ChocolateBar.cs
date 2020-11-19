using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateBarDebugging
{
    class ChocolateBar
    {
        public string Name
        public string Brand;
        private int Calories;
        
        public ChocolateBar(string name)
        {
            Name = name;
        }

        public ChocolateBar()
        {
        }

        public ChocolateBar(string name, string brand, int calories)
        {
            name = Name;
            brand = Brand;
            Calories = calories;
        }

        public void eat()
        {
            Console.WriteLine("Yum! You just ate a  + Brand + " " + Name);
        }

        public void giveTo(person)
        {
            Console.WriteLine("You just donated a chocolate bar");
        }
    }
}
