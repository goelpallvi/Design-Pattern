using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterens
{
   public class PizzaDecorator : CountryPizzaAbstract
    {
        public IPizza pizza;
            
        public PizzaDecorator(CountryPizzaAbstract countryPizzaAbstract)
        {
            countryPizzaAbstract.SetFlavour(countryFlavour);
            //    countryPizzaAbstract.countryFlavour 
            return countryPizzaAbstract;

        }

    }
}
