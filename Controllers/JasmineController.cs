using System;
using System.Web.Mvc;

namespace AngularJsExample2.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return View("SpecRunner");
        }
    }
}
