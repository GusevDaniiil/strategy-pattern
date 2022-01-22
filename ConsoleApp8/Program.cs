using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace MyDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            ReadheadDuck readheadDuck = new ReadheadDuck();



            Duck[] ducks = new Duck[] { mallardDuck, readheadDuck };

            foreach ( var x in ducks)
            {
                Console.WriteLine(x.Quack());
                Console.WriteLine(x.Swim());
                Console.WriteLine(x.Display());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

    
}