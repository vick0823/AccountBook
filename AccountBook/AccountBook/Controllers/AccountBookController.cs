using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AccountBook.Models;   

namespace AccountBook.Controllers
{
    public class AccountBookController : Controller
    {
        // GET: AccountBook
        public ActionResult Index()
        {
            List<AccountBookViewModel> data = new List<AccountBookViewModel>();
            data.Add(new AccountBookViewModel {
                Type = "收入",
                Date = "2017-08-09",
                Money = 1000
            });
            data.Add(new AccountBookViewModel
            {
                Type = "支出",
                Date = "2017-08-09",
                Money = 888
            });
            data.Add(new AccountBookViewModel
            {
                Type = "收入",
                Date = "2017-08-10",
                Money = 66666
            });
            return View(data);
        }
    }
}