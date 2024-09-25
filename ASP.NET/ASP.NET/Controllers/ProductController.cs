using ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository repo;

    public ProductController(IProductRepository repo)
    {
        this.repo = repo;
    }

    // GET: /<controller>/
    public IActionResult Index()
    {
        var products = repo.GetAllProducts();
        return View(products);
    }
}
