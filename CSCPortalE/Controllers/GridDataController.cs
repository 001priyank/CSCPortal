using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSCPortalE.Service;

namespace CSCPortalE.Controllers
{
    public class GridDataController : Controller
    {
        //
        // GET: /GridData/


        public JsonResult getCSCInitiativeGridDisplayResult()
        {
            var _service = new GridDataService();

            int page = int.Parse(Request.QueryString["page"]);

            int rows = int.Parse(Request.QueryString["rows"]);


            var gridData = _service.getCSCInitiativeGridDisplayResult();
            var jsonData = new
            {
                total = gridData.Count / 10, //todo: calculate
                page = page,
                records = gridData.Count,
                rows =
                    (from data in gridData
                     select new
                     {
                         id = data.CSCInitiativeID,
                         cell = new string[] { data.CSCInitiativeID.ToString(), data.CSCInitiativeName.ToString() , data.Location.ToString() , data.HomePage.ToString() , data.DLID.ToString() , data.CreatedDate.ToShortDateString()  }
                     }).Skip((page) * rows - rows).Take(rows).ToArray()

            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
        public JsonResult getCSCInitiativeTeamGridDisplayResult()
        {
            var _service = new GridDataService();

            int page = int.Parse(Request.QueryString["page"]);

            int rows = int.Parse(Request.QueryString["rows"]);


            var gridData = _service.getCSCInitiativeTeamGridDisplayResult();
            var jsonData = new
            {
                total = gridData.Count / 10, //todo: calculate
                page = page,
                records = gridData.Count,
                rows =
                    (from data in gridData
                     select new
                     {
                         id = data.TeamID,
                         cell = new string[] { data.CSCInitiativeID.ToString() , data.TeamID.ToString() , data.TeamName.ToString() , data.Location.ToString() , data.HomePage.ToString() , data.DLID.ToString() , data.CreatedDate.ToShortDateString() , data.EmpID.ToString(),data.CSCInitiativeName.ToString()  }
                     }).Skip((page) * rows - rows).Take(rows).ToArray()

            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }


    }
}
