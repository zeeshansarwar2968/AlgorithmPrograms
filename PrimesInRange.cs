using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class PrimesInRange
    {
        //initialising initial values for the program
        int endPoint = 1000, count =0,counter=0;
        
        //Method/Function to find the prime numbers upto 1000
        public void FindPrimes()
        {
            //running the loop upto the endPoint(1000)
            for (int i = 2; i < endPoint; i++)
            {
                count = 0;
                
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.Write(i + "  ");
                        //counter++;
                    }
                



            }
        }
    }
}
