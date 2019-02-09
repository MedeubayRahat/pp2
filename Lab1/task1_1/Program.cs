using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int cnt = 0;
            bool flag = false;
           
           for(int i = 0;i < n;i++)
            {
                flag = false;
                if (a[i] <= 1) continue;
                else
                    for (int j = 2; j < a[i]; j++)
                        if (a[i] % j == 0) flag = true;
                if (!flag) cnt++;
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < n; i++)
            {
                flag = false;
                if (a[i] <= 1) continue;
                else
                    for (int j = 2; j < a[i]; j++)
                        if (a[i] % j == 0) flag = true;
                if (!flag) Console.Write(a[i] + " ");    
            }
            Console.ReadKey();
        }
    }
   }

