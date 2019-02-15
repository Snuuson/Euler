using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem12
    {

        public void P() {
            Console.WriteLine("---Problem 12---");
            Util u = new Util();
            int max = 0;
            bool found = false;

            int index = 1;
            while (!found)
            {
                long triangleNumber = 0;
                int tempIndex = index;
                for (; tempIndex > 0; tempIndex--) {
                    triangleNumber += tempIndex;
                }
                

                int tmp = u.getDividers(triangleNumber).Count;
                if (tmp > max) {
                    max = tmp;
                }
                if (tmp >= 500) {
                    found = true;
                    Console.WriteLine(index + " " + triangleNumber);
                }
                index++;
                if (index % 10000 == 0) {
                    Console.WriteLine(index);
                    
                    Console.WriteLine(max);
                }
            }
        }
        
    }
}
