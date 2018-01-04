using System.Net;
using System.Web.Mvc;
using DentalSelect.Web.DAL;
using DentalSelect.Web.BL;

namespace DentalSelect.Web.Controllers
{
    public class SubscribersController : Controller
    {
        // GET: Subscribers
        public ActionResult Index(string searchString)
        {
            var subscribers = SubscriberHelper.GetSubscribers(searchString);
            return View(subscribers);
        }

        // GET: Subscribers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subscribers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,State,ZipCode")] Subscriber subscriber)
        {
            if (ModelState.IsValid)
            {
                SubscriberHelper.AddSubscriber(subscriber);
                return RedirectToAction("Index");
            }
            return View(subscriber);
        }     

        // GET: Subscribers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var subscriber = SubscriberHelper.FindSubscriber((int)id);
            if (subscriber == null)
            {
                return HttpNotFound();
            }
            return View(subscriber);
        }

        // POST: Subscribers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubscriberHelper.DeleteSubscriber(id);
            return RedirectToAction("Index");
        }
    }
}
