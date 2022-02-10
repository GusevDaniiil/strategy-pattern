﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ReadheadDuck : Duck, IQuackable, IFlyable
    {
        public override string Display()
        {
            return "Display " + this.GetType();
        }
        public string Fly()
        {
            return "Fly" + this.GetType();
        }
        public string Quack()
        {
            return "Quack" + this.GetType();
        }
    }
}
