using System;
using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {
        Random random = new Random();
        LuckySpin.Models.Spin spin = new LuckySpin.Models.Spin();

        //The Conroller to receive the Luck number from the Route
        public IActionResult Index(int luck = 7) //Default value for luck is 7
        {
            int a = random.Next(1, 10);
            int b = random.Next(1, 10);
            int c = random.Next(1, 10);
            LuckySpin.Models.Spin spin = new LuckySpin.Models.Spin();

            // Load up the ViewBag for use by the Spinner View "Index.cshtml"
            spin .ImgDisplay = (a == luck || b == luck || c == luck)?"block":"none";
            spin.A = a;
            spin.B = b;
            spin.C = c;
            spin.luck = luck;

            return View(spin);
        }
    }
}