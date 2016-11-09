using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using WebApplicationMVC.HelpClasses;

namespace WebApplicationMVC.Controllers
{
    public class GoodsController : Controller
    {
        // GET: TODOListItems
        public ActionResult Index()
        {
            try
            {
                return View(Singleton.Instance.Repository.GetAll());
            }
            catch(Exception ex)
            {
                return View("Error");
            }
        }

        // GET: TODOListItems/Details/5
        public ActionResult Details(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                ServiceReference.Goods goods;
                goods = Singleton.Instance.Repository.Get((int)id);
                if (goods == null)
                {
                    return HttpNotFound();
                }
                return View(goods);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        // GET: TODOListItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TODOListItems/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Description,Price")] ServiceReference.Goods goods)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Singleton.Instance.Repository.Create(goods);
                    return RedirectToAction("Index");
                }
                return View(goods);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        // GET: TODOListItems/Edit/5
        public ActionResult Edit(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                ServiceReference.Goods goods;
                goods = Singleton.Instance.Repository.Get((int)id);
                if (goods == null)
                {
                    return HttpNotFound();
                }
                return View(goods);

            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        // POST: TODOListItems/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Description,Price")] ServiceReference.Goods goods)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Singleton.Instance.Repository.Update(goods);
                    return RedirectToAction("Index");
                }
                return View(goods);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        // GET: TODOListItems/Delete/5
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                ServiceReference.Goods goods;
                goods = Singleton.Instance.Repository.Get((int)id);
                if (goods == null)
                {
                    return HttpNotFound();
                }
                return View(goods);
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }

        // POST: TODOListItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Singleton.Instance.Repository.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View("Error");
            }
        }
    }
}
