using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            List<IHunt> hunters = new List<IHunt>();
            hunters.Add(tiger);
            List<IWalk> walkers = new List<IWalk>();
            walkers.Add(new Turtle());
            walkers.Add(tiger);
            foreach(IHunt hunter in hunters)
            {
                hunter.Hunt();
            }
            foreach(IWalk walker in walkers)
            {
                walker.Walk();
            }
            Console.ReadKey();
        }
    }
}
