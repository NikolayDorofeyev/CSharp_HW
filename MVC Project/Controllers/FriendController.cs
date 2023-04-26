using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class FriendController : Controller
    {
        private List<Friend> friends = new List<Friend>
        {
            new Friend { FriendID = 1, FriendName = "John", Place = "New York" },
            new Friend { FriendID = 2, FriendName = "Jane", Place = "Los Angeles" },
            new Friend { FriendID = 3, FriendName = "Bob", Place = "Chicago" },
            new Friend { FriendID = 4, FriendName = "Alice", Place = "San Francisco" },
        };

        public ActionResult Index()
        {
            return View(friends);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Friend friend)
        {
            if (ModelState.IsValid)
            {
                friend.FriendID = friends.Count + 1;
                friends.Add(friend);
                return RedirectToAction("Index");
            }

            return View(friend);
        }

        public ActionResult Edit(int? id)
        {
            Friend friend = friends.FirstOrDefault(f => f.FriendID == id);

            return View(friend);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Friend friend)
        {
            if (ModelState.IsValid)
            {
                var friendUpdated = friends.FirstOrDefault(f => f.FriendID == friend.FriendID);
                if (friendUpdated != null)
                {
                    friendUpdated.FriendName = friend.FriendName;
                    friendUpdated.Place = friend.Place;
                }
                return RedirectToAction("Index");
            }

            return View(friend);
        }

        public ActionResult Delete(int? id)
        {
            
            var friend = friends.FirstOrDefault(f => f.FriendID == id);
            

            return View(friend);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var friend = friends.FirstOrDefault(f => f.FriendID == id);
            if (friend != null)
            {
                friends.Remove(friend);
            }

            return RedirectToAction("Index");
        }
    }
}