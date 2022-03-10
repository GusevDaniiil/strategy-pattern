using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DQuack: IQuackBehavior
    {
        public string Quack()
        {
            return "Quack";
        }
    }
}
