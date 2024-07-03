using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialEX
{
    internal class master
    {
        public void m1()
        {
            int a,b;
            a = 1; b = 2;
            int c = a + b;
            Console.WriteLine("Addtion=" + c);
        }
        public int m2<ax,by>( ax s, by b)
        {
           return Convert.ToInt32(s) + Convert.ToInt32(b);
        }
       
    }
}
