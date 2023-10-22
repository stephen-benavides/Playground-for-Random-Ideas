using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFun.repo
{
    public class Orders
    {
        private readonly ITime _time;
        public Orders(ITime time)
        {
            this._time = time;
        }
        public int GetMinutes(int minute)
        {
            return _time.GetMinutes(minute);
        }

    }
}
