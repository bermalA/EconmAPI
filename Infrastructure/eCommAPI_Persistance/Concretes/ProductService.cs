using eCommAPI_Application.Abstractions;
using eCommAPI_Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommAPI_Persistance.Concretes
{
    public class ProductService : IProductService

    {
        public List<Product> GetProducts()
        => new()
        {
            new() { ID = 1, Name= "Product Name",CreatedDate = DateTime.Now,Price = 20,StockNumber = 100 },
            new() { ID = 2, Name= "Product Name2",CreatedDate = DateTime.Now,Price = 20,StockNumber = 100 },
            new() { ID = 3, Name= "Product Name3",CreatedDate = DateTime.Now,Price = 20,StockNumber = 100 },
            new() { ID = 4, Name= "Product Name4",CreatedDate = DateTime.Now,Price = 20,StockNumber = 100 },
            new() { ID = 5, Name= "Product Name5",CreatedDate = DateTime.Now,Price = 20,StockNumber = 100 }
        };
    }
}
