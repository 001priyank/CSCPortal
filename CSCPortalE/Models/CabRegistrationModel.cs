using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSCPortalE.Models
{
    public class CabRegistrationModel
    {
        public IEnumerable<SelectListItem> CSCInitiatives;
        public IEnumerable<SelectListItem> CSCInitiativeTeams;
        public IEnumerable<SelectListItem> Routes;
        public String EmpID;
        public DateTime EnterDate;
        

    }

    public class CabRegistrationGridDisplayModel
    {
        public String EmpID;
        public int CabRegistrationID;
        public String CSCInititative;
        public String CabRoute;
        public DateTime CabRegistrationDate;
        public int Status;

    }
}