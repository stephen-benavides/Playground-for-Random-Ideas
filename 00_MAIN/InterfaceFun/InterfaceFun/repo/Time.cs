using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFun.repo
{
    public interface ITime
    {
        int GetMinutes(int minute);
    }

    public class Time : ITime
    {
        public int Minutes { get; set; }
        public int CurrentTime { get; set; }

        public int GetMinutes(int minute)
        {
            this.Minutes = DateTime.Now.Minute;
            return Minutes+minute;
        }
    }
}
