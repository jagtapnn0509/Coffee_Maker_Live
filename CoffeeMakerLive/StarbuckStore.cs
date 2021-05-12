using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMakerLive
{
    public class StarbuckStore
    {
        private readonly IMakeCoffee service;


        //readonly const

        public StarbuckStore(IMakeCoffee service)
        {
            this.service = service;
        }

        public string OrderCoffee(int sugarPerSpoon, int coffeeCount)
        {
            if (service.CheckIngredientAvailability())
            {
                return service.CoffeeMaking(sugarPerSpoon, coffeeCount);
            }
            else
            {
                return "Sorry! Coffee is not available.";
            }
        }

    }
}
