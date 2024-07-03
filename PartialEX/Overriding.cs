using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialEX
{
    internal class Overriding
    {
        public virtual void widro()
            {
                Console.WriteLine("Widthdro mony");
            }

       
    }
    class sjdssd : Overriding
    {
        public override void widro()
        {
            Console.WriteLine("this derive class mathod");
        }
    }
}