using System;

namespace DesignPatterens
{
    public class Main
    {
    
        CountryPizzaAbstract CountryPizzaAbstract = CountryPizzaFactory.GetCountryPizzaInstance(PizzaType.France);
       
        //it is abstract factory patteren design
        IPizza pizza = PizzaFactory.GetSpecificPizza(Pizzas.ROMANA);
        PizzaDecorator decorator = new PizzaDecorator(CountryPizzaAbstract);
    }
}
