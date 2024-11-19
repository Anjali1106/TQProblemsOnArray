using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsOnArray
{
    // 10. Shift negative before positive in array
    internal class Ques18
    {
       // 10. Shift negative before positive in array
        static void Main(String[] args) {
            int j = 0;

            int[] arr = { 2, 3, -4, 5, -2, 7, -6, 9 };
            while (j < arr.Length && arr[j] < 0)
                j++;

            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
                
            }
        }
    }
}
