using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.DAL.Repository
{
    interface IProductRepository
    {
        public void Save(string name, string price);
    }
}
