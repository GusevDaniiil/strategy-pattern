using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FlyWithWings : IFlyBehavior
    {
        public string Fly()
        {
            return "I'm flying!";
        }
    }
}
