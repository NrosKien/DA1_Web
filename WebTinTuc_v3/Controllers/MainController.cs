using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTinTuc_v3.Models;

namespace WebTinTuc_v3.Controllers
{
    public class MainController : Controller
    {
        WebTinTucEntities db = new WebTinTucEntities();
        // GET: Main
        public ActionResult Index ()
        {
            return View();
        }
        public ActionResult Detail ()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Login(TAIKHOAN t)
        {
            var user = db.TAIKHOANs.Where(s => s.ID == t.ID && s.Password == t.Password).FirstOrDefault();
            //var checkRole = db.TAIKHOANs.Where(s => s.LoaiTaiKhoan == t.LoaiTaiKhoan).FirstOrDefault();
            if (user == null)
            {
                return PartialView();
            }
            else
            {
                db.Configuration.ValidateOnSaveEnabled = false;
                Session["ID"] = t.ID;
                Session["Password"] = t.Password;

                //Error Role
                if (user.LoaiTaiKhoan.Contains("Admin"))
                {
                    return RedirectToAction("Main", "Admin");
                }
                else if(user.LoaiTaiKhoan.Contains("NguoiDuyetBai"))
                {
                    
                }
                else if (user.LoaiTaiKhoan.Contains("NguoiDangBai"))
                {

                }   
                else
                {
                    
                }
                return PartialView();
            }
        }
    }
}