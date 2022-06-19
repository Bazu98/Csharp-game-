using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_first_project

{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(fibonacci(6));
            int[] x = { 1, 4, 6, 7, 1, 78, 7 };
            int key = 1;
            Console.WriteLine(Binary(x, key));
            int [] y = {[3,2,99,75,30,1];
}
            Console.WriteLine(Sorting(y));

        }


        public static int fibonacci(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else { 
            }
                return fibonacci(n - 1) + fibonacci(n - 2);
        }

        public static int Binary(int [] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                    return (i + 1);
            }
            return -1;
        }

        public static void Sorting(int[] arr)
{
        for (var i = 0; i < arr.Length; i++)
        {
            var min = i;
            for(var j = i + 1; j < arr.Length; j++) { 
                if(input[min] > input[j])
                {
                    min = j;
                }
            }
        }
}


    }



}