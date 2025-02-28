using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeSelin.Controllers
{
    public class MessageController : Controller

    {
        // GET: Message
        MessageManager cm= new MessageManager(new EFMessageDal());
        public ActionResult Inbox()
        {
            var messageList = cm.GetListInbox();
            return View(messageList);
        }
        public ActionResult Sendbox()
        {
            var messageList = cm.GetListSendbox();
            return View(messageList);
        }
        public ActionResult GetInBoxMessageDetails(int id)
        {
            var values = cm.GetById(id);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            return View();
        }
    }
}