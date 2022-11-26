﻿using System.Diagnostics;
using BigData.Data;
using Microsoft.AspNetCore.Mvc;
using BigData.Models;

namespace BigData.Controllers;

public class HomeController : Controller
{
    private BigDataRushContext db = new BigDataRushContext();
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Product> products = db.products.ToList();
        return View("Index", products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Computers()
    {
        throw new NotImplementedException();
    }
    public IActionResult Sort(string? param)
    {
        var Students = db.products.ToList();
        switch (param)
        {
            case "name":
                Students = Students.OrderBy(s => s.pr_name).ToList();
                break;
            case "price":
                Students = Students.OrderBy(s => s.pr_price).ToList();
                break;
            default:
                break;
        }
        return View("Index", Students);
    }
}