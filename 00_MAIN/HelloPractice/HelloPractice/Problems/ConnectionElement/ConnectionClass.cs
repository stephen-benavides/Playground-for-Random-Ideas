using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HelloPractice.ConnectionElement
{
    public class ConnectionClass
    {
        public String Name { set; get; }
        String password { set; get; }
        int id { set; get; }

        public ConnectionClass(string name, string password)
        {
            Name = name;
            this.password = password;
        }

        public ConnectionClass(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

        public String returnSomething()
        {

            return "ConenctionClassString";
        }
    }
}