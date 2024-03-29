﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    [Serializable]
    public class StoreItem : InventoryItem
    {   
        public StoreItem(Product _product, int _quantity)
        {
            Quantity = _quantity;
            Product = _product;
        }

        public override string ToString()
        {
            return $"#{this.Product.Id}# <{this.Product.Name}>:<{this.Quantity}>";
        }
    }
}
