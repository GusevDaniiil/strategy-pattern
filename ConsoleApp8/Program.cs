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
            RubberDuck rubberDuck = new RubberDuck();
            DecoyDuck decoyDuck = new DecoyDuck();

            IFlyBehavior flyBehavior = new FlyNoWay();
            IQuackBehavior quackBehavior = new DQuack();

            mallardDuck.SetFlyBehavior(flyBehavior);
            rubberDuck.SetQuackBehavior(quackBehavior);

            Duck[] ducks = new Duck[] { mallardDuck, readheadDuck, rubberDuck, decoyDuck };

            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].Display());
                Console.WriteLine(ducks[i].Swim());
                Console.WriteLine(ducks[i].PerformFly());
                Console.WriteLine(ducks[i].PerformQuack() + "\n");
            }

            Console.ReadKey();
        }
    }

    
}