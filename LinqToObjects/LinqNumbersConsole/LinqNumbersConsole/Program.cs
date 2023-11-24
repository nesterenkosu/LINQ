using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqNumbersConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,10,5,20,8,7,3,16,9};

            var res = from num in nums
                        group num by (num % 2 == 0)?"Чётное":"Нечётное";

            foreach(var group in res)
            {
                Console.WriteLine("Группа ["+group.Key+"]");
                Console.WriteLine("К-во элементов: "+ group.Count());
                Console.WriteLine("Список элементов:");
                foreach (var el in group)
                    Console.WriteLine(el);
                Console.WriteLine("");
            }
            

            Console.ReadLine();
        }
    }
}
