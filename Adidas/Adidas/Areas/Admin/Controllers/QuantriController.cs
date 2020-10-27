using Adidas.Models.Enity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Adidas.Areas.Admin.Controllers
{
    public class QuantriController : BaseController
    {
        public adidasEntities db = new adidasEntities();
        // GET: Admin/Quantri
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Add(Sanpham sanpham)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //add vào db
                    db.Sanphams.Add(sanpham);
                    db.SaveChanges();
                    return Json(new { StatusCode = 200 }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    //Tên input, lỗi
                    IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                    return Json(new { StatusCode = 500, Message = allErrors.FirstOrDefault().ErrorMessage }, JsonRequestBehavior.AllowGet);
                }
            }
            catch
            {
                return Json(new { StatusCode = 505, Message = "Lỗi Thêm Mới" }, JsonRequestBehavior.AllowGet);
            }
        }

    }

}