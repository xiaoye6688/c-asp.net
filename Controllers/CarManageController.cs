using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarManageMVCEFDemo.Models;

namespace CarManageMVCEFDemo.Controllers
{
    public class CarManageController : Controller
    {
        CarEntity db = new CarEntity();
        // GET: CarManage
        /// <summary>
        /// 绑定车辆信息（主页）
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            var list = db.CarRecord.ToList();
            return View(list);
        }
        [HttpPost]
        public ActionResult Index(string CarNo,string Tell)
        {
            var list = db.CarRecord.ToList();
            if (!string.IsNullOrEmpty(CarNo))
            {
                list = list.Where(a=>a.CarNo.Equals(CarNo)).ToList();
            }
            if (!string.IsNullOrEmpty(Tell))
            {
                list = list.Where(a => a.Mobile.Equals(CarNo)).ToList();
            }
            return View(list);
        }
        /// <summary>
        /// 添加车辆信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult InserCar()
        {
            var list = db.CommunityInfo.ToList();
            ViewData["dd"] = new SelectList(list, "CId", "CommunityName");
            return View();
        }
        [HttpPost]
        public ActionResult InserCar(CarRecord car)
        {
            car.DriveTime = DateTime.Now;
            db.CarRecord.Add(car);
            int i = db.SaveChanges();
            if (i>0)
            {
                return Content(@"<script>alert('添加成功！');location.href='"+Url.Action("Index") +"'</script>");
            }
            else
            {
                return Content(@"<script>alert('添加失败！');location.href='" + Url.Action("InserCar") + "'</script>");
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        public ActionResult Dele(int id)
        {
            var list = db.CarRecord.Where(a => a.CarId == id).FirstOrDefault();
            db.CarRecord.Remove(list);
            int i = db.SaveChanges();
            return Json(i, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 授权
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ShouQuan(int id)
        {
            var list = db.CarRecord.Where(a => a.CarId == id).FirstOrDefault();
            list.Type = 1;
            int i = db.SaveChanges();
            return Json(i, JsonRequestBehavior.AllowGet);
        }
    }
}