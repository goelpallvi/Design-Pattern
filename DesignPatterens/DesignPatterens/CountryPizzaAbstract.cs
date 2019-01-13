using DesignPatterens.Modela;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterens
{
    public abstract class CountryPizzaAbstract
    {
        public string CountryName;
        public string countryFlavour;
        public CountryPizzaAbstract()
        {

        }
        protected CountryPizzaAbstract(string countryName)
        {
            CountryName = countryName;
        }
        protected  virtual void SetFlavour(Flavour flavour)
        {
           countryFlavour = flavour.ToString();

        }
     //public CreateCountryPizza()
     //   {
     //       return new C

     //   }
        

    }
}
