using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using CSCPortalE.Models;

namespace CSCPortalE.repository
{
    public class  CabRegistrationRepository
    {
        CSCPortalDataContext _dataContext = new CSCPortalDataContext();
       
        public List<SelectListItem> getCSCIntitiatives()
        {
           var items = (from item in _dataContext.tbCSCInitiatives
                         select item);
           List<SelectListItem> returnItems=new List<SelectListItem>();
            foreach (var item in items)
           {
               returnItems.Add(new SelectListItem
               {
                   Text=item.CSCInitiativeName,
                   Value=item.CSCInitiativeID.ToString()
               });


           }

            return returnItems;

        }

        //Team
        public List<SelectListItem> getCSCIntitiativeTeams()
        {
            var items = (from item in _dataContext.tbCSCInitiativeTeams
                         select item);
            List<SelectListItem> returnItems = new List<SelectListItem>();
            foreach (var item in items)
            {
                returnItems.Add(new SelectListItem
                {
                    Text = item.TeamName,
                    Value = item.TeamID.ToString()
                });


            }

            return returnItems;

        }

        // Route
        public List<SelectListItem> getRoutes()
        {
            var items = (from item in _dataContext.tbCabRoutes
                         select item);
            List<SelectListItem> returnItems = new List<SelectListItem>();
            foreach (var item in items)
            {
                returnItems.Add(new SelectListItem
                {
                    Text = item.CabRouteName,
                    Value = item.CabRouteID.ToString()
                });


            }

            return returnItems;

        }

        //Registration
         public bool CabRegistrationSubmit(tbCabRegistration cabreg)
        {
            try
            {
                _dataContext.tbCabRegistrations.InsertOnSubmit(cabreg);
                _dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
            
        }

         //CabRegistration Grid 
         public List<CabRegistrationGridDisplayModel> getCabRegistrationGridDisplayResult()
         {
             var registrationItems = (from data in _dataContext.tbCabRegistrations
                                      orderby data.Date descending
                                      select data);
             var dataToReturnItems = (from item in registrationItems
                                      select new CabRegistrationGridDisplayModel
                                      {
                                          EmpID = item.EmpID,
                                          CabRegistrationID = item.CabRegistrationID,
                                          CSCInititative = (from inititative in _dataContext.tbCSCInitiatives
                                                            where inititative.CSCInitiativeID == item.CSCInitiativeID
                                                            select inititative.CSCInitiativeName).FirstOrDefault()??string.Empty,

                                          CabRoute = (from route in _dataContext.tbCabRoutes
                                                      where route.CabRouteID == item.CabRouteID
                                                      select route.CabRouteName).FirstOrDefault()??string.Empty,
                                          CabRegistrationDate = item.Date,
                                          Status = item.Status ??0
                                      });


             return dataToReturnItems.ToList();



         }
    }
}
