using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem8 p8 = new Problem8();
            Problem9 p9 = new Problem9();
            Problem10 p10 = new Problem10();
            Problem11 p11 = new Problem11();
            Problem12 p12 = new Problem12();
            Util u = new Util();

            Console.WriteLine("-Util-");
            /*
            ArrayList al = u.getDividers(1000);
            
            Console.WriteLine(al.Count);
            al.Sort();
            foreach (Object value in al) {
                
                Console.WriteLine(value);

            }
            */

            p8.P();
            p9.P();
            p10.P();
            p11.P();
            p12.P();
            Console.WriteLine("-End-");
            Console.ReadKey();
        }
    }
}
