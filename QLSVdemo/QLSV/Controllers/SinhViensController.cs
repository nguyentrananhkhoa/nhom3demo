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
            
        }

        // GET: SinhViens/Details/5
        public ActionResult Details(string id)
        {
           
        }

        // GET: SinhViens/Create
        public ActionResult Create()
        {
            
        }

        // POST: SinhViens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSV,HoTen,DiaChi,TenLop")] SinhVien sinhVien)
        {
           
        }

        // GET: SinhViens/Edit/5
        public ActionResult Edit(string id)
        {
            //Sửa code tại đây
        }

        // POST: SinhViens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSV,HoTen,DiaChi,TenLop")] SinhVien sinhVien)
        {
           //Sửa code tại đây
        }

        // GET: SinhViens/Delete/5
        public ActionResult Delete(string id)
        {
            
        }

        // POST: SinhViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
           
        }

        protected override void Dispose(bool disposing)
        {
            
        }
    }
}
