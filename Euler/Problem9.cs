using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem9
    {
        public void P() {
            int a = 0;
            int b = 1;
            int c = 2;
            bool found = false;
            while (!found && c <= 1000) {

                b = c - 1;
                a = b - 1;
                for (; b > 0 && !found; b--) {
                    a = b - 1;
                    for (; a > 0 && !found; a--)
                    {
                        if (((a + b + c) == 1000)) {
                            if (((a * a) + (b * b) == (c * c))) {
                                Console.WriteLine("---Problem 9---");
                                Console.WriteLine("a: " + a + ", b: " + b + ", c: " + c);
                                Console.WriteLine("Product = " + (a*b*c));
                                found = true;
                            }
                            
                        }
                    }
                }

                c++;
            }

        }
    }
}
