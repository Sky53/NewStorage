﻿using Storage.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.DAL.Repository
{
   public interface IProductRepository
    {
        public void Save(Product product);
        public IEnumerable<Product> GetProducts();
    }
}
