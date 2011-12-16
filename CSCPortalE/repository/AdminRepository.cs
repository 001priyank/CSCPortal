using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCPortalE.Repository
{
    public class AdminRepository
    {
        private CSCPortalDataContext _dataContext = new CSCPortalDataContext();

        public bool SetCSCInitiative(tbCSCInitiative cscini)
        {
            try
            {
                
                _dataContext.tbCSCInitiatives.InsertOnSubmit(cscini);
                _dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                return false;
            }
               return true;
        }
        public bool SetCSCInitiativeTeam(tbCSCInitiativeTeam csciniteam)
        {
            try
            {
                _dataContext.tbCSCInitiativeTeams.InsertOnSubmit(csciniteam);
                _dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool SetRoute(tbCabRoute cabroute)
        {

            try
            {
                _dataContext.tbCabRoutes.InsertOnSubmit(cabroute);
                _dataContext.SubmitChanges();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool RegisterToCSCInitiativeTeam(String TeamID, String EmpID)
        {
            try
            {
                var register = new tbEmpInCSCInitiativeTeam();
                register.CSCInitiativeID = (from cscini in _dataContext.tbCSCInitiativeTeams

                                            where cscini.TeamID == int.Parse(TeamID)
                                            select cscini.CSCInitiativeID.Value).FirstOrDefault() ;
                    
                   
                register.TeamID = int.Parse(TeamID);
                register.EmpID = EmpID;
                _dataContext.tbEmpInCSCInitiativeTeams.InsertOnSubmit(register);
                _dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool RegisterToCSCInitiative(String CSCInitiativeID,String EmpID)
        {
            try
            {
                var register = new tbEmpInCSCInitiativeTeam();
                register.CSCInitiativeID = int.Parse(CSCInitiativeID);
              
                register.EmpID = EmpID;
                _dataContext.tbEmpInCSCInitiativeTeams.InsertOnSubmit(register);
                _dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool ApproveCab(String CabRegistrationId)
        {
            try
            {
                var toApprove = (from cabItem in _dataContext.tbCabRegistrations
                                 where cabItem.CabRegistrationID == int.Parse(CabRegistrationId)
                                 select cabItem).FirstOrDefault();
                toApprove.Status = 1;
                _dataContext.SubmitChanges();
                return true;
                
            }
            catch (Exception e)
            {
                return false;
            }

        }

    }



}
