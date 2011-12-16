using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSCPortalE.Service;

namespace CSCPortalE.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CSCInitiative()
        {
            var cscini = new tbCSCInitiative();
            cscini.CreatedDate = DateTime.Now;
            return View(cscini);
        }
        [HttpPost]
        public ActionResult CSCInitiative(tbCSCInitiative cscini)
        {
            AdminService _service = new AdminService();
           if( _service.SetCSCInitiative(cscini))
           
            return View(cscini);
           return View("Error");
        }

        //CSCInititativeTeam
        public ActionResult CSCInitiativeTeam()
        {
            var csciniteam = new tbCSCInitiativeTeam();
            csciniteam.CreatedDate = DateTime.Now;
            return View(csciniteam);
        }
        [HttpPost]
        public ActionResult CSCInitiativeTeam(tbCSCInitiativeTeam csciniteam)
        {
            AdminService _service = new AdminService();
            if (_service.SetCSCInitiativeTeam(csciniteam))

                return View(csciniteam);
            return View("Error");
        }
        
        //CabRoute

        public ActionResult CabRoute()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CabRoute(tbCabRoute cabroute)
        {
            AdminService _service = new AdminService();
            if (_service.SetRoute(cabroute))

                return View(cabroute);
            return View("Error");
        }

        public JsonResult RegisterToCSCInitiativeTeam()
        {
            String TeamID = Request.QueryString["TeamID"];
            String EmpID = HttpContext.User.Identity.Name;
            var _service = new AdminService();
            return Json(_service.RegisterToCSCInitiativeTeam(TeamID, EmpID), JsonRequestBehavior.AllowGet); ;
        }

        public JsonResult RegisterToCSCInitiative(String CSCInitiativeID)
        {
            String EmpID = HttpContext.User.Identity.Name;
            var _service = new AdminService();
            return Json(_service.RegisterToCSCInitiative(CSCInitiativeID, EmpID),JsonRequestBehavior.AllowGet);
        }

        public JsonResult ApproveCab(String id)
        {
            var _service = new AdminService();

            return Json(_service.ApproveCab(id), JsonRequestBehavior.AllowGet);
        }
            


    }
}
