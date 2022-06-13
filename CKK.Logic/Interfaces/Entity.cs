using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CKK.Logic.Models;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    public abstract class Entity
    {
        private int _Id;
        private string _Name;

        public int Id
        {
            get { return _Id; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidIdException();
                }
                else
                {
                    _Id = value;
                }
            }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
    }
}
