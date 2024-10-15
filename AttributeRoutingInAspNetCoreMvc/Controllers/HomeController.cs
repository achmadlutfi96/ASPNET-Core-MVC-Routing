using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AttributeRoutingInAspNetCoreMvc.Models;

namespace AttributeRoutingInAspNetCoreMvc.Controllers;

[Route("Home")]
public class HomeController : Controller
{
    // [Route("")]
    // [Route("Home")]
    // [Route("Home/Index")]

    // [Route("")]
    // [Route("/")]
    // [Route("Index")]

    [HttpGet("")]
    [HttpGet("/")]
    [HttpGet("Index")]
    public string Index()
    {
        return "Index() Action Method of HomeController";
    }

    // [Route("Home/Details/{id}")]
    // [Route("Home/Details/{id?}")]  // Optional value id
    // [Route("Home/Details/{id=10}")]   // default value id

    // [Route("Details/{id?}")]

    [HttpGet("Details/{id?}")]
    public string Details(int id)
    {
        return "Details() Action Method of HomeController, ID Value = " + id;
    }

    // [Route("~/About")] // ignore controller route attribute

    [HttpGet("~/About")]
    public string About(int id)
    {
        return "About() Action Method of HomeController";
    }

    // [Route("")]
    // [Route("MyHome")]
    // [Route("MyHome/Index")]
    // public string StartPage()
    // {
    //     return "StartPage() Action Method of HomeController";
    // }

    // public string Privacy()
    // {
    //     return "Privacy() Action Method of HomeController";
    // }
}
