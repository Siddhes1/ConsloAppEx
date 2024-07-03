using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace PartialEX
{
     partial class Class1
    {
     
        public int a=10,q=10,r;
        public void add()
        {
           
            r = a + q;
            Console.WriteLine("1Add="+r);
        }
    }
    partial class Class2:Class1
    {
        public void mul()
        {
            r = a * q;
            Console.WriteLine("2multiplication="+r);
        }
    }
     partial class Class1
    {
        public void div()
        {
            r = a / q;
            Console.WriteLine("div=" + r);
        }
    }
    class show:Class1
    {
       public void display()
        {
            Console.WriteLine("R=" + r);
            Console.WriteLine("A=" + a);
            Console.WriteLine("Q=" + q);
        }
    }static class Extension
    {
        static public void diaplay(this master master )
        {
            Console.WriteLine(" i am in Exension Class");
        }
    }

}
