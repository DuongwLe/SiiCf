using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Storage
{
    public class ncc
    {
        private string name;
        private string address;
        private string phonenumber;

        public ncc(string name, string address, string phonenumber)
        {
            this.name = name;
            this.address = address;
            this.phonenumber = phonenumber;
        }
        public string Name { get { return name; } set { name = value; } } 
        public string Address { get { return address; } set { address = value; } } 
        public string PhoneNumber { get { return phonenumber; } set { phonenumber = value; } }
    }
}
