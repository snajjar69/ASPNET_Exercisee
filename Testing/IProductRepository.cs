using System;
using System.Collections.Generic;
using Testing.Models;

namespace Testing;

public interface IProductRepository
{
    //GET ALL
    IEnumerable<Product> GetAllProducts();

// GET SINGLE
    Product GetProduct(int id);
    void UpdateProduct(Product product);
  
}