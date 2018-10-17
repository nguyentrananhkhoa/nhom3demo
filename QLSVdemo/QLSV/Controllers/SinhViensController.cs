using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLSV.Models;

namespace QLSV.Controllers
{
    public class SinhViensController : Controller
    {
        private QuanLiSinhVien db = new QuanLiSinhVien();

        // GET: SinhViens
        public ActionResult Index()
        {
            return View(db.SinhViens.ToList());
        }

        // GET: SinhViens/Details/5
        public ActionResult Details(string id)
        {
            return View();
        }

        // GET: SinhViens/Create
        public ActionResult Create()
        {
            ViewBag.TenLop = new SelectList(db.Lops.ToList().OrderBy(n => n.TenLop), "MaLop", "TenLop");
            return View();
        }

        // POST: SinhViens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSV,HoTen,DiaChi,TenLop")] SinhVien sinhVien)
        {
            ViewBag.TenLop = new SelectList(db.Lops.ToList().OrderBy(n => n.TenLop), "MaLop", "TenLop");
            
            if (ModelState.IsValid)
            {
                db.SinhViens.Add(sinhVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sinhVien);
        }

        // GET: SinhViens/Edit/5
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: SinhViens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSV,HoTen,DiaChi,TenLop")] SinhVien sinhVien)
        {
            return View();
        }

        // GET: SinhViens/Delete/5
        public ActionResult Delete(string id)
        {
            return View();
        }

        // POST: SinhViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            
        }
    }
}
