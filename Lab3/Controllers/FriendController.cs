using Lab3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class FriendController : Controller
    {
        private static List<FriendModel> friends = new List<FriendModel>{new FriendModel() {  idFriend=4,ime = "imence", mestoZiveenje = "addrejsa" }};
        // GET: Friend
        public ActionResult Index()
        {
            return View();
        }

        
        //GET
        //ovaa f-ja e za prikaz na forma za vnesuvanje na nov friend
        public ActionResult NewFriend()
        {
            //pravime prazen friend
            FriendModel model = new FriendModel();
            return View(model);
        }


        //GET
        public ActionResult EditFriend(int id)
        {
            FriendModel friend = friends.ElementAt(id);
            friend.Id = id;
            return View(friends.ElementAt(id));
        }
        public ActionResult GetAllFriends()
        {
            return View(friends);
        }
        //POST
        [HttpPost]
        public ActionResult EditFriend(FriendModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            FriendModel forUpdate = friends.ElementAt(model.Id);
            forUpdate.idFriend = model.idFriend;
            forUpdate.ime = model.ime;
            forUpdate.mestoZiveenje = model.mestoZiveenje;
            return View("GetAllFriends", friends);
        }
       


        //POST
        //ovaa f-ja se povikuva togas koga kje se klikne SUBMIT kopceto za noviot friend
        [HttpPost]
        public ActionResult NewFriend(FriendModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            friends.Add(model);
            //se prenasocuvame na novo view
            return View("GetAllFriends", friends);
        }


        public ActionResult DeleteFriend(int id)
        {
            friends.RemoveAt(id);
            return View("GetAllFriends", friends);
        }



    }
}