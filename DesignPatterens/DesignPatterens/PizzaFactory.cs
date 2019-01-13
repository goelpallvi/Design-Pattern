using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterens
{
    //this is a pizza factory that will return the pizza by decorating what country the pizza would be
    //So first what in main class the abstract factory create the country
    public enum Pizzas
    {
        SALMONE, ROMANA
    }
    public class PizzaFactory
    {
      

        public static IPizza GetSpecificPizza(Pizzas type)
        {
            IPizza pizza =null;

            switch (type)
            {
                case Pizzas.ROMANA:
                    pizza = new Romana();
                    break;
                case Pizzas.SALMONE:
                    pizza = new Salmonia();
                    break;

                  
            }
            return pizza;
        }
    }
}
