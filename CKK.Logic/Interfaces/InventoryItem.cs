using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    public abstract class InventoryItem
    {
        private Product _Product;
        private int _Quantity;

        public Product Product
        {
            get { return _Product; }
            set { _Product = value; }
        }

        public int Quantity
        {
            get { return _Quantity; }
            set
            {
                if (value < 0)
                {
                    throw new InventoryItemStockTooLowException();
                }
                else
                {
                    _Quantity = value;
                }
            }
        }
    }
}
