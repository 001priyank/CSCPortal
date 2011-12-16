using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using CSCPortalE.repository;
using CSCPortalE.Models;

namespace CSCPortalE.Service
{
    public class CabRegistrationService
    {
      
        public static IEnumerable<SelectListItem> getCSCIntitiatives()
        {
            CabRegistrationRepository _repository = new CabRegistrationRepository();
           return _repository.getCSCIntitiatives();
        }
        public static  IEnumerable<SelectListItem> getCSCIntitiativeTeams()
        {
            CabRegistrationRepository _repository = new CabRegistrationRepository();
           return _repository.getCSCIntitiativeTeams();
        }
        public static IEnumerable<SelectListItem> getRoutes()
        {
            CabRegistrationRepository _repository = new CabRegistrationRepository();
            return _repository.getRoutes();
        }

        public bool CabRegistrationSubmit(tbCabRegistration cabreg)
        {
            CabRegistrationRepository _repository = new CabRegistrationRepository();
           var status= _repository.CabRegistrationSubmit(cabreg);
           return status;

           
        }
        public List<CabRegistrationGridDisplayModel> CabRegistrationGridDisplay()
        {
            CabRegistrationRepository _repository = new CabRegistrationRepository();
            var returnToGrid = _repository.getCabRegistrationGridDisplayResult();
            return returnToGrid;

        }
        public static List<SelectListItem> getCSCInitiativeTeamIsSPOC()
        {
            List<SelectListItem> returnItems = new List<SelectListItem>();
            returnItems.Add(new SelectListItem
              {
                  Text = "Yes",
                  Value = "Yes"
              });
            returnItems.Add(new SelectListItem
            {
                Text = "No",
                Value = "No"
            });
            return returnItems;

        }
    }
}
