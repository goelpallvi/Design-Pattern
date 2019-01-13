using DesignPatterens.Modela;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterens
{
    //countryPizzaAbstract should only conTAIn the name of the pizza
    public class SalmoniaPizza : CountryPizzaAbstract
    {
        Flavour flavour;

        public SalmoniaPizza() : base()
        {

        }
       public SalmoniaPizza(string name) : base(name)

        {

        }
    
        public override SetFlavour(Flavour flavour )
        {
            flavour = flavour;

        }
       

      
    }
}
