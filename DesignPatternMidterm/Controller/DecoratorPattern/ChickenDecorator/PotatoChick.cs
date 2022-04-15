﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Controller.DecoratorPattern.ChickenDecorator
{
    public class PotatoChick : ChickenDecorator
    {
        public PotatoChick(IChicken chicken) : base(chicken)
        {
        }

        public override String doChicken()
        {
            String type = base.doChicken();
            return type + addPotatoTopping();

        }
        public override double Cost()
        {
            return 5000+base.Cost();
        }
        private String addPotatoTopping()
        {
            {
                return " + Khoai tây chiên";
            }
        }
    }
}
