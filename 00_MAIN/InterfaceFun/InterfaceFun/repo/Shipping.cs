using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFun.repo
{
  
    public class Shipping
    {
        private Orders _orders;
        public int Minutes { get; set; }
        public Shipping(Orders orders)
        {
            _orders = orders;
            Console.WriteLine("Minute inside ctor: {0}", Minutes);
        }

        public void GetTomorrowsDate(int minute)
        {
            Minutes = _orders.GetMinutes(minute);
           // Console.WriteLine("Minute inside method: {0}", Minutes);
        }


    }
}
