using DesignPatterens.Modela;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterens
{
   public interface ICountryPizza
    {
          Flavour  flavour{  set; }
        void SetFlavour(Flavour countryFlavour);
        

    }
}
