using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiesePA2
{
    class IceCream
    {
        private int choc,
            straw,
            van,
            toppings,
            apparatus;

        double iceCreamCost,
            toppingsCost,
            apparatusCost;

        //create parameterized constructor
        public IceCream (int chocolate, int strawberry, int vanilla, int topp, int app)
        {
            choc = chocolate;
            straw = strawberry;
            van = vanilla;
            toppings = topp;
            apparatus = app;

            IceCost();
            ToppCost();
            AppaCost();

        }


        private double IceCost()
        {
            return iceCreamCost = (choc + straw + van) * 0.99;
        }

        private double ToppCost()
        {
            return toppingsCost = toppings * 0.25;
        }

        private void AppaCost()
        {
            if (apparatus == 1)
            {
                apparatusCost = 1.75;
            }
            else
            {
                apparatusCost = 2.00;
            }
        }

        public double FinalCost()
        {
            return iceCreamCost + toppingsCost + apparatusCost;
        }



    }
}
