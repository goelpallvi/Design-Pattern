using DesignPatterens.Modela;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterens
{
   public class FrancePizza :CountryPizzaAbstract
    {
        Flavour flavour;

        public FrancePizza()
        {

        }
        public FrancePizza(string name) : base(name)

        {

        }

        public void SetFlavour(Flavour flavour)
        {
            flavour = flavour;

        }


    }
}
