using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Davai.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        private Models.ShopDBEntities1 db = new Models.ShopDBEntities1();
        public ActionResult Index()
        {
            var Items = db.ItemLists;
            return View(Items);
        }
        public ActionResult ItemPage(int itemlist_id)
        {
            var Item = db.ItemLists.FirstOrDefault(x => x.Id == itemlist_id);
            if (Item == null)
                return Content("<n1>Страница не найдена</h1>");
            return View(Item);
        }
        //public ActionResult Nav()
        //{
        //    var Items = db.ItemLists;
        //    string result = "";
        //    foreach(var item in Items){
        //        result += "<li><a href='/Shop/ItemPage/?item_id=" + item.Id + "' title='" + item.Name + "'>" + item.Name + "</a></li>";
        //    }
        //    return Content(result);
        //}
        public ActionResult Form(int itemlist_id)
        {
            ViewBag.Item = itemlist_id;
            return PartialView();
        }
    }
}