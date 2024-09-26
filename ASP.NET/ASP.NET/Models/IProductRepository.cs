using System;
using System.Collections.Generic;
using ASP.NET.Models;



namespace ASP.NET.Models;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    Product GetProduct(int id);
}