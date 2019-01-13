using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterens
{
    public enum PizzaType
    {
        France, SALMONE, ROMANA
    }

    public class CountryPizzaFactory
    {
        


        public static CountryPizzaAbstract GetCountryPizzaInstance(PizzaType type)
        {
            CountryPizzaAbstract countryPizzaAbstract = new SalmoniaPizza();
            //TestPizza testPizza = new Salmonia();
            switch (type)
            {
                case PizzaType.France
                :
                    countryPizzaAbstract = new FrancePizza();
                    break;
                case PizzaType.ROMANA:
                    countryPizzaAbstract= new SalmoniaPizza();
                    break;
            }

            return countryPizzaAbstract;


        }
    }
}
