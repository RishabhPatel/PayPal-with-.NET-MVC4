using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using PayPal.Models;

namespace PayPal.Controllers
{
    public class PayPalController : Controller
    {
        //
        // GET: /PayPal/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ValidateCommand(string product, string totalPrice)
        {
            bool useSandbox = Convert.ToBoolean(ConfigurationManager.AppSettings["IsSandbox"]);
            var paypal = new PayPalModel(useSandbox);

            paypal.item_name = product;
            paypal.amount = totalPrice;
            return View(paypal);
        }

        public ActionResult RedirectFromPaypal()
        {
            return View();
        }

        public ActionResult CancelFromPaypal()
        {
            return View();
        }

        public ActionResult NotifyFromPaypal()
        {
            return View();
        }


    }
}
