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
 //Update
    public  void UpdateProduct(Product product);
    public void InsertProduct(Product productToInsert);
    //Get Categories
    public IEnumerable<Category> GetCategories();
    public Product AssignCategory();
    public void DeleteProduct(Product product);
}
