using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    class Turtle:IWalk
    {
        public void Walk()
        {
            Console.WriteLine("I'm a turtle, I walk slow.");
        }
    }
}
