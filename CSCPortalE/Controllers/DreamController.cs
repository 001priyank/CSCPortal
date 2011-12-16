using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSCPortalE.Service;
using CSCPortalE.Models;

namespace CSCPortalE.Controllers
{
    public class DreamController : Controller
    {
        //
        // GET: /Dream/

        public ActionResult DreamGallery()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        private String getStatus(int StatusId)
        {
            switch (StatusId)
            {
                case 4:
                    return "Accepted";

                case 1:
                    return "Submitted";
                case 2:
                    return "Returned For Consideration";
                case 3:
                    return "Invited For Discussion";
                case 5:
                    return "Rejected";
                case 6:
                    return "Deleted";
                default:
                    return "Unknown";

            }
        }
        public JsonResult DreamGridData()
        {
            int page = int.Parse(Request.QueryString["page"]);

            int rows = int.Parse(Request.QueryString["rows"]);

            var _service = new DreamService();
            var gridData = _service.DreamGridDisplay();
            var jsonData = new
            {
                total = gridData.Count / 10, //todo: calculate
                page = page,
                records = gridData.Count,
                rows =
                    (from data in gridData
                     select new
                     {
                         id = data.DreamId,
                         cell = new string[] { data.DreamId.ToString(), data.DreamTitle ?? "", data.DreamDescription ?? "", data.EmpId ?? "", data.EmpName ?? "", data.Location?? "", data.SubmittedDate ?? string.Empty, getStatus(int.Parse(data.Status)) ?? "", data.ContactPerson ?? "" }
                     }).Skip((page) * rows - rows).Take(rows).ToArray()

            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DreamView()

        {
            //Priyank TODO
            var model = new DreamGridDisplayModel();
            model.DreamTitle = "";
            model.DreamDescription = "";
            model.ContactPerson = "";
            return View(model);
        }
        [HttpPost]

        public ActionResult DreamView(DreamGridDisplayModel dreamModel)
        {
            var _service = new DreamService();
            _service.DreamFormUpdate(dreamModel);
            return View(dreamModel);


        }
        public ActionResult DreamSubmit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DreamSubmit(DreamGridDisplayModel dreamModel)
        {
            var _service = new DreamService();
             var dreamTable=new tbDream();
             ProfileService profileService = new ProfileService();
             dreamTable.EMPID = HttpContext.User.Identity.Name ?? string.Empty;
             dreamTable.EMPNAME = profileService.getEmpName(HttpContext.User.Identity.Name) == null ? String.Empty : profileService.getEmpName(HttpContext.User.Identity.Name);
             //dreamTable.LOCATION = profileService.getPhone(empID) == null ? String.Empty : profileService.getPhone(empID);
             dreamTable.LOCATION = profileService.getLocation(HttpContext.User.Identity.Name) == null ? String.Empty : profileService.getLocation(HttpContext.User.Identity.Name);
           
            dreamTable.DTITLE=dreamModel.DreamTitle ?? string.Empty;
            dreamTable.DDESCRIPTION = dreamModel.DreamDescription ?? string.Empty;
           
            dreamTable.SUBMITTEDDATE = DateTime.Now;
            dreamTable.STATUSID = 1;
            _service.DreamFormSubmit(dreamTable);

            return View();
        }

        public PartialViewResult DreamUserView()
        {
            return PartialView("DreamUserView");
        }
        public PartialViewResult DreamAdminView()
        {
            return PartialView("DreamAdminView");
        }

        public JsonResult DreamFormBind(String id)
        {
            var _service = new DreamService();
            var modelDataToReturn= _service.DreamFormBind(id);
            return Json(modelDataToReturn, JsonRequestBehavior.AllowGet);

        }

    }
}
