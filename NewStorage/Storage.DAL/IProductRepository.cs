using Storage.Domain;
using System.Collections.Generic;

namespace Storage.DAL
{
    public interface IProductRepository
    {
        public List<Product> GetAllProducts();

        public void SaveProduct(string name, string price);
    }
}