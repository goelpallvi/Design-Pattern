using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterens
{
    public class Salmonia : CountryPizzaAbstract,IPizza
    {
        public Salmonia()
        {

        }

        public void GetPizza()
        {
            throw new NotImplementedException();
        }
    }
}
