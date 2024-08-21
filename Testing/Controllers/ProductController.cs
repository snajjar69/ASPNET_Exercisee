using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Testing.Models;
using System.Runtime;

namespace Testing.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository _repo;

    public ProductController(IProductRepository repo)
    {
        _repo = repo;
    }

    // GET: /Controller>/
    public IActionResult Index()
    {
        var products = _repo.GetAllProducts();
        return View(products);
    }

    public IActionResult ViewProduct(int id)
    {
        var product = _repo.GetProduct(id);

        if (product == null)
        {
            return View("ProductNotFound");
        }

        return View(product);
    }
    
    public IActionResult UpdateProduct(int id)
    {
        var product = _repo.GetProduct(id);

        if (product == null)
        {
            return View("ProductNotFound");
        }

        return View(product);
    }

    public IActionResult UpdateProductToDatabase(Product product)
    {
        _repo.UpdateProduct(product);
        return RedirectToAction("ViewProduct", new { id = product.ProductID });
    }
  }
