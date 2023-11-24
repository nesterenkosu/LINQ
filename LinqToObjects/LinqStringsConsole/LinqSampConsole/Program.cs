using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSampConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { 
                "Яблоко", 
                "Апельсин", 
                "Ананас", 
                "Абрикос", 
                "Мандарин", 
                "Лимон",
                "Манго",
                "Груша",
                "Грейпфрут"
            };

            //Пример 1
            Console.WriteLine("Пример 1");
            Console.WriteLine("-------------------------------");

            var fruits_a = from f in fruits
                           where f.Length > 5
                           group f by f.Substring(0,1) into g  
                           orderby g.Key ascending
                           select "На букву "+g.Key+" всего: "+g.Count()+" шт ("+g.Aggregate((sum,item)=>sum+","+item)+")";

            foreach (string fruit in fruits_a)            
                Console.WriteLine(fruit);

            Console.WriteLine("");

            //Пример 2
            Console.WriteLine("Пример 2");
            Console.WriteLine("-------------------------------");

            var fruits_a_v2 = from f in fruits
                              group f by f.Substring(0, 1);

            foreach(var group in fruits_a_v2)
            {
                Console.WriteLine("Группа "+group.Key+" содержит элементы:");
                foreach (var item in group)
                    Console.WriteLine(item);

                Console.WriteLine(" ");
            }

            Console.ReadLine();
        }
    }
}
