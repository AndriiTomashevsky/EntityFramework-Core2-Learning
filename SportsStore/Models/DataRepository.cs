﻿using System.Collections.Generic;
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

        public Product GetProduct(long key)
        {
            return context.Products.Find(key);
        }

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }
    }
}