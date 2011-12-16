using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSCPortalE.Service;

namespace CSCPortalE.Controllers
{
    public class CabRegistrationController : Controller
    {
        //
        // GET: /CabRegistration/

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CabRegistration()
        {
            var model = new CSCPortalE.Models.CabModel();
            model.EmpID = HttpContext.User.Identity.Name;
           

            
            return View(model);
        }

        [HttpGet]
        public ActionResult CabRegistrationSubmit()
        {       
         CabRegistrationService _service=new CabRegistrationService();
            var model = new tbCabRegistration();
            var CSCInitiativeID=int.Parse( Request.QueryString["CSCInitiativeID"]);
            model.CSCInitiativeID = CSCInitiativeID;
            model.EmpID = HttpContext.User.Identity.Name;
            var date1 = Request.QueryString["EnterDate"];
            var enterdate = DateTime.Parse(date1.ToString());
           model.Date = enterdate;
           model.CabRouteID = int.Parse(Request.QueryString["CabRouteID"]);
           _service.CabRegistrationSubmit(model);
                return View();
        }
        [HttpPost]
        public ActionResult CabRegistration(CSCPortalE.Models.CabModel model)
        {
            
            return View();
        }


        public ActionResult CabRegistrationView()
        {
            return View();
        }

        public JsonResult CabRegistrationGridData()
        {
            CabRegistrationService _service = new CabRegistrationService();

            int page = int.Parse(Request.QueryString["page"]);

            int rows = int.Parse(Request.QueryString["rows"]);


            var gridData = _service.CabRegistrationGridDisplay();
            var jsonData = new
            {
                total = gridData.Count / 10, //todo: calculate
                page = page,
                records = gridData.Count,
                rows =
                    (from data in gridData
                     select new
                     {
                         id = data.CabRegistrationID,
                         cell = new string[] { data.EmpID.ToString(), data.CabRegistrationID.ToString(), data.CSCInititative.ToString(), data.CabRoute.ToString(), data.CabRegistrationDate.ToShortDateString(), data.Status.ToString()??string.Empty }
                     }).Skip((page) * rows - rows).Take(rows).ToArray()

            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }



    }
}
