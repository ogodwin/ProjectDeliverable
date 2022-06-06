using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Interfaces
{
    public class InventoryItem
    {
        protected CKK.Logic.Models.Product _Product;
        protected int _Quantity;

        public CKK.Logic.Models.Product Product
        {
            get { return _Product; }
            set { _Product = value; }
        }

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
    }
}
