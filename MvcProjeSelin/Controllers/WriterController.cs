using DataAccessLayer.EntityFramework;
using DataAccessLayer.Concrete.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using BusinessLayer.ValidationRules_FluentValidation;
using FluentValidation.Results;

namespace MvcProjeSelin.Controllers
{
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterDal());
        public ActionResult Index()
        {
            var WriterValues = wm.GetList();
            return View(WriterValues);
        }
        [HttpGet]
        public ActionResult AddWriter()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(Writer p)
        {
            WriterValidator writervalidator = new WriterValidator();
            ValidationResult results = writervalidator.Validate(p);
            if (results.IsValid)
            {
                wm.WriterAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);


                }
            }
            return View();
        }
    }
}
