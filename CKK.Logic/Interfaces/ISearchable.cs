using System;
using System.Linq;
using CKK.Logic.Models;
using CKK.Logic.Interfaces;

namespace CKK.Logic.Interfaces {

    public interface ISearchable {

        public StoreItem SearchById();

        public StoreItem SearchByName();

    }
}