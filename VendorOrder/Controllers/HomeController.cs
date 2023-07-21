using Microsoft.AspNetCore.Mvc;
//skyview of the project
namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      [Route("/favorite_photos")]
  public ActionResult FavoritePhotos()
  {
    return View();
  }

    }
}