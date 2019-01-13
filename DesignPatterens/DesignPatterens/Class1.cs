using System;

namespace DesignPatterens
{
    public class Main
    {
    
       public CountryPizzaAbstract CountryPizzaAbstract = CountryPizzaFactory.GetCountryPizzaInstance(PizzaType.France);
        PizzaDecorator decorator = new PizzaDecorator(CountryPizzaAbstract);

        //it is abstract factory patteren design
        IPizza pizza = PizzaFactory.GetSpecificPizza(Pizzas.ROMANA, decorator);
    }
}
