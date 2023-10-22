using System;
using InterfaceFun.repo;

namespace InterfaceFun
{
    class Program
    {
        static void Main(string[] args)
        {

            var order = new Orders(new Time());
            //var time = new Time();
            //order.time = new Time();
            var shipping = new Shipping(new Orders(new Time()));
            shipping.GetTomorrowsDate(minute:20);
            Console.WriteLine(shipping.Minutes);
            shipping.GetTomorrowsDate(minute: 45);
            Console.WriteLine(shipping.Minutes);

         
        }
    }
}
