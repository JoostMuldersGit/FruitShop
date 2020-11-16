using System;

namespace Fruitshop
{
    public class Pineapple : Fruit
    {
        public string Peel()
        {
            Console.WriteLine("Peeling");
            return "Ok";
        }
    }
}