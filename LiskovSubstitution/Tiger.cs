using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Tiger : IHunt, IWalk, IRun
    {
        public void Hunt()
        {
            Console.WriteLine("I'm a tiger, I hunt");
        }

        public void Run()
        {
            Console.WriteLine("I'm a tiger, I run");
        }

        public void Walk()
        {
            Console.WriteLine("I'm a tiger, I walk");
        }
    }
}
