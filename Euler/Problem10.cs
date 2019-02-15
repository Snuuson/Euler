using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem10
    {

        public void P() {
            Console.WriteLine("---Problem 10---");
            long result = 0;

            Util U = new Util();
            bool[] PA = U.SieveOfEratosthenes(2000000-1);

            
            for(long i = 0; i < PA.Length; i++)
            {
                if (PA[i] == true) {
                    result += i;
                }

            }
            Console.WriteLine(result);
        }
    }
}
