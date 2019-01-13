using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterens.Modela;

namespace DesignPatterens
{
    public class Romana : CountryPizzaAbstract,IPizza
    {
       // Flavour ICountryPizza.flavour { set => throw new NotImplementedException(); }

        public void GetPizza()
        {

        }

        public void ICountryPizza.SetFlavour(Flavour countryFlavour)
        {
            throw new NotImplementedException();
        }
    }
}
