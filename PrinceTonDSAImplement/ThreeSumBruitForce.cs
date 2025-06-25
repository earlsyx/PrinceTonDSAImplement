using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinceTonDSAImplement
{
    public class ThreeSumBruitForce
    {
        public int Count(int[] a)
        {
            int n = a.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++) 
                    for (int k = j + 1; k < n; k++)
                      if (a[i] + a[j] + a[k] == 0)        
                            count++;
                       
            return count;
        }
    }
}
