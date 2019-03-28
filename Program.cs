using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_the_Triplets
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

        }

        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> results = new List<int>();
            int resultA = 0;
            int resultB = 0;
            for(int i = 0; i< 3;i++)
            {
               
                    if (a[i] > b[i])
                    {
                        resultA = resultA + 1;
                    }
                    else if (a[i] < b[i])
                    {
                        resultB = resultB + 1;
                    }
                
            }
            results.Insert(0, resultA);
            results.Insert(1, resultB);
            return results;
        }
    }



}
