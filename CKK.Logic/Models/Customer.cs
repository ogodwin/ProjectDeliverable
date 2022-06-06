using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Customer : CKK.Logic.Interfaces.Entity
    {
        public string Address;

        public int GetId()
        {
            return Id;
        }

        public void SetId(int customerid)
        {
            Id = customerid;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string customername)
        {
            Name = customername;
        }

        public string GetAddress()
        {
            return Address;
        }

        public void SetAddress(string customeraddress)
        {
            Address = customeraddress;
        }
    }
}
