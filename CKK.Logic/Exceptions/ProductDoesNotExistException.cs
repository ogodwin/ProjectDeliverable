using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Exceptions
{
    public class ProductDoesNotExistException : Exception
    {
        [Serializable]
        public ProductDoesNotExistException() : base("Product does not exsist")
        {

        }

    }
}
