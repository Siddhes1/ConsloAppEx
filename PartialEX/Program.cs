using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Class1 class1 = new Class1();
            //class1.add();
            //class1.div();
            Class2 class2 = new Class2();
            //class2.mul();
            class2.add();
            //class2.div();
            //class1.div();
            //show show = new show();
            //show.div();
            //show.add();
            //show.display();
            master master = new master();
            master.m1();
            master.diaplay();
            master m2= new master();    
            m2.diaplay();

         Overriding overriding  = new Overriding();
            overriding.widro();
            sjdssd sjdssd = new sjdssd();   
            sjdssd.widro();

        }
    }
}
