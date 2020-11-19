using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateBarDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBar boost = new ChocolateBar("Boost", "Cadbury", 250);
            ChocolateBar twix = new ChocolateBar("Twix", "Mars", 286);

            // program should output: "Yum! You just ate a Cadbury Boost"
            boost.eat();

            // program should output: "You just donated 286 calories of Mars goodness in Twix form to Mr Walsh"
            twix.giveTo("Mr Walsh");

            // Brand should be set to Mystery
            // Name should be set to Chocolate Bar
            ChocolateBar b = new ChocolateBar();
            
            // program should output: "Yum! You just ate a Mystery Chocolate Bar"
            b.eat();
        }
    }
}
