using System.Collections.Generic;

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
                return context.Products;
            }
        }

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}