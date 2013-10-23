using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPOS
{
    class pizzaOrder
    {
        // Variables
        private int numberOfCokes;
        private int numberOfPizzas;

        // Default Constructor
        public pizzaOrder(int _numbCokes, int _numbPizza)
        {
            NumbCokes = _numbCokes;
            NumbPizza = _numbPizza;
        }

        // Properties
        public int NumbCokes
        {
            get { return numberOfCokes; }
            set { numberOfCokes = value; }
        }

        // Properties
        public int NumbPizza
        {
            get { return numberOfPizzas; }
            set { numberOfPizzas = value; }
        }

        // Method: Get Input Order
        
        // Method: Get Amount Due

        // Method: Get Change Due


    }
}
