using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using ExerciseBayshoreSolutions.Infraestructure;

namespace ExerciseBayshoreSolutions.Controllers
{
    public class ConverterController : Controller
    {
	    public ActionResult Converter()
	    {
		    return View();
	    }

		[HttpPost]
	    public ActionResult Converter(double number)
	    {
			ConverterHelper	helper = new ConverterHelper();
		    var NumberConverted = helper.ConvertNumberToString(number);
		    return Json(new { res = NumberConverted});
	    }
    }
}
