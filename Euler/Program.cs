using System;
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

            p8.P();
            p9.P();
            p10.P();
            Console.WriteLine("-End-");
            Console.ReadKey();
        }
    }
}
