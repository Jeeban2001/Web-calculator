using calculator_in_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace calculator_in_web.Controllers
{
    public class Calc : Controller
    {

		public ActionResult Index()
        {
			return View(new calc());
        }
        [HttpPost]
            public ActionResult Index(calc c, string calculate)
        {
            if (calculate == "add")
            {
				c.tot = c.no1 + c.no2;
            }
            else if (calculate == "min")
            {
				c.tot = c.no1 - c.no2;
            }
            else if (calculate == "sub")
            {
                c.tot = c.no1 * c.no2;
            }
            else
            {
                c.tot = c.no1 / c.no2;
            }
            return View(c);
        }
    }
}
