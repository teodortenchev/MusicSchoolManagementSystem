namespace DubaiMusicSchool.Web.Controllers
{
    using System.Diagnostics;

    using DubaiMusicSchool.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        [Route("/about")]
        public IActionResult About()
        {
            return this.View();
        }

        [Route("/contact")]
        public IActionResult Contact()
        {
            return this.View();
        }

        [Route("~/courses")]
        public IActionResult Courses()
        {
            return this.View();
        }

        [Route("/events")]
        public IActionResult Events()
        {
            return this.View();
        }

        [Route("~/teachers")]
        public IActionResult Teachers()
        {
            return this.View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
