using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSCPortalE.Models;

namespace CSCPortalE.repository
{
     public enum Status : int
        {
            Submitted=1,
         ReturnedForConsideration,
         InvitedForDiscussion,
         Accepted,
         Rejected,
         Deleted
        }

    public class GridDataRepository
    {
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
        public List<CSCInitiativeGridDisplayModel> getCSCInitiativeGridDisplayResult()
        {
            var _dataContext = new CSCPortalDataContext();
            var cscini = (from data in _dataContext.tbCSCInitiatives
                                     orderby data.CreatedDate descending
                                     select data);
            var dataToReturnItems = (from item in cscini
                                     select new CSCInitiativeGridDisplayModel
                                     {
                                         CSCInitiativeID=item.CSCInitiativeID,
                                         CSCInitiativeName = item.CSCInitiativeName.ToString() ?? string.Empty,
                                         Location = item.Location.ToString() ?? string.Empty,
                                         HomePage = item.HomePage.ToString() ?? string.Empty,
                                         DLID = item.DLID.ToString() ?? string.Empty,
                                         CreatedDate=item.CreatedDate.GetValueOrDefault()
                                        
                                     });


            return dataToReturnItems.ToList();

        }
        public List<CSCInitiativeTeamGridDisplayModel> getCSCInitiativeTeamGridDisplayResult()
        {
            var _dataContext = new CSCPortalDataContext();
            var cscini = (from data in _dataContext.tbCSCInitiativeTeams
                          orderby data.CreatedDate descending
                          select data);
            var dataToReturnItems = (from item in cscini
                                     select new CSCInitiativeTeamGridDisplayModel
                                     {
                                          CSCInitiativeID=item.CSCInitiativeID.GetValueOrDefault(),
                                          TeamName=item.TeamName.ToString()??string.Empty,

                                          EmpID = item.EmpID.ToString() ?? string.Empty,
                                          Location = item.Location.ToString() ?? string.Empty,
                                          HomePage = item.HomePage.ToString() ?? string.Empty,
                                          DLID = item.DLID.ToString() ?? string.Empty,
                                         CreatedDate = item.CreatedDate.GetValueOrDefault(),
                                          TeamID = item.TeamID.ToString() ?? string.Empty,
                                          CSCInitiativeName=(from data in _dataContext.tbCSCInitiatives 
                                                             where data.CSCInitiativeID==item.CSCInitiativeID
                                                             select data.CSCInitiativeName).FirstOrDefault()??string.Empty

                                     });


            return dataToReturnItems.ToList();

        }
       

        public List<DreamGridDisplayModel> getDreamGridDisplayResult()
        {
            var _dataContext = new CSCPortalDataContext();
            var dreamResult = (from dream in _dataContext.tbDreams
                               where dream.STATUSID!=6
                               select dream).OrderByDescending(x => x.SUBMITTEDDATE);
            var dataToReturn = (from dream1 in dreamResult
                                select new DreamGridDisplayModel
                                {
                                     DreamId=dream1.DID,
                                     DreamTitle=dream1.DTITLE,
                                     DreamDescription=dream1.DDESCRIPTION,
                                     EmpId = dream1.EMPID ,
                                     EmpName = dream1.EMPNAME ,
                                     Location = dream1.LOCATION ,
                                     SubmittedDate = dream1.SUBMITTEDDATE.Value.ToShortDateString() ,
                                     Status= dream1.STATUSID.ToString(),
                                     ContactPerson=dream1.CONTACTPERSON.ToString() 
                                     
                                });
            return dataToReturn.ToList();
        }
    }
}