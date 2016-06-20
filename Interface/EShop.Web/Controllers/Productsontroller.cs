using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EShop.Web.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            try
            {
            }
            catch (Exception ex)
            {
                //Log To DB
            }
            return View();
        }

        //[Authorize]
        public ActionResult AddToCart(long ProductID)
        {
            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    //Add Shoping Cart to session
                }
            }
            catch (Exception ex)
            {
                //Log To DB
            }
            return View();
        }
    }
}