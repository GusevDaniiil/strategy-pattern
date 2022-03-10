using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck()
        {

        }

        public string Display()
        {
            return this.GetType() + " " + this.flyBehavior + " " + this.quackBehavior;
        }
        public string PerformFly()
        {
            return flyBehavior.Fly();
        }
        public string PerformQuack()
        {
            return quackBehavior.Quack();
        }
        public IFlyBehavior SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
            return flyBehavior;
        }
        public IQuackBehavior SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
            return quackBehavior;
        }

        public string Swim()
         {
                return "All ducks float, even decoy!";
         }
  

    }
}
    

