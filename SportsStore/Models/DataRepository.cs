using System.Collections.Generic;

namespace SportsStore.Models
{
    public class DataRepository : IRepository
    {
        private List<Product> data = new List<Product>();

        public IEnumerable<Product> Products
        {
            get
            {
                return data;
            }
        }

        public void AddProduct(Product product)
        {
            data.Add(product);
        }
    }
}
