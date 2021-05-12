using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMakerLive
{
   
        public class Starbucks : IMakeCoffee
    {
            public bool CheckIngredientAvailability()
            {
                return true;
            }

            public string CoffeeMaking(int sugerPerSpoon, int CoffeePack)
            {
                return "";
            }
        }

        public class StubStarbucks : IMakeCoffee
        {
            public bool CheckIngredientAvailability()
            {
                return true;
            }

            public string CoffeeMaking(int sugerPerSpoon, int CoffeePack)
            {
                return "Your order is received.";
            }
        }


    
}
