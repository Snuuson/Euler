using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Euler
{
    class Util
    {
        public bool[] SieveOfEratosthenes(int n)
        {

            // Create a boolean array "prime[0..n]" and initialize 
            // all entries it as true. A value in prime[i] will 
            // finally be false if i is Not a prime, else true. 

            bool[] prime = new bool[n + 1];

            for (int i = 0; i < n; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
                // If prime[p] is not changed, 
                // then it is a prime 
                if (prime[p] == true)
                {
                    // Update all multiples of p 
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            prime[0] =  false;
            prime[1] = false;
            return prime;

        }
         
        public ArrayList getDividers(long n) {

            ArrayList dividers = new ArrayList();

            long tmp = n;
            for (int i = 1; i < tmp; i++) {
                if (n % i == 0) {
                    dividers.Add((Int64)i);
                    dividers.Add((Int64)(n / i));
                    tmp = n / i;
                }
            }


            return dividers;
        }
    }
}
