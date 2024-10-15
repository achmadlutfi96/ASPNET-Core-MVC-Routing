using Microsoft.AspNetCore.Mvc;
namespace RoutingAspNetCoreMvc.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "Index() Action Method of StudentController";
        }
        public string Details(int? id)
        {
            return $"Details({id}) Action Method of StudentController";
        }
    }
}