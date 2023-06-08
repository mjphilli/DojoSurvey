using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    // [HttpGet]
    // [Route("")]
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpPost("addInfo")]
    public IActionResult AddInfo(string Name, string Location, string Language, string Comment)
    {
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        if (string.IsNullOrEmpty(Comment))
        {
            Comment = "No comment";
        }
        ViewBag.Comment = Comment;
        return View("Results");
    }
}