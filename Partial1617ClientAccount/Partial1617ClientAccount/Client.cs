using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Partial1617ClientAccount
{
    class Client
    {
        //fields
        private String name, address;
        //properties
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        // constructor
        public Client(String name, String address)
        {
            this.name = name; this.address = address;
        }
        public override string ToString()
        {
            return "Name: " + name + " Address: " + address;
        }
    }
}
