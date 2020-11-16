using System;

namespace Fruitshop
{
    public class Orange : Fruit
    {
        public string Squeeze()
        {
            Console.WriteLine("Squeez");
            return "Ok";
        }
    }
}