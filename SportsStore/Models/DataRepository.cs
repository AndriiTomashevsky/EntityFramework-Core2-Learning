using System.Collections.Generic;
using System.Linq;

namespace SportsStore.Models
{
    public class DataRepository : IRepository
    {
        private DataContext context;

        public DataRepository(DataContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Product> Products
        {
            get
            {
                return context.Products.ToArray();
            }
        }

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}