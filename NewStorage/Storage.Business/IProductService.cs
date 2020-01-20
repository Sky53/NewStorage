using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Business
{
   public interface IProductService
    {
        public void AddProduct(string name, string price);
    }
}
