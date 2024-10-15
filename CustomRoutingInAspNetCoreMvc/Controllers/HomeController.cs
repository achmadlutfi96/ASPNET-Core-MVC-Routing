using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CustomRoutingInAspNetCoreMvc.Models;

namespace CustomRoutingInAspNetCoreMvc.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        return View();
    }

    public ViewResult Details(int id)
    {
        return View();
    }
}
