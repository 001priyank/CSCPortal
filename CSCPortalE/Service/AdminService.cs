using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSCPortalE.Repository;

namespace CSCPortalE.Service
{
    public class AdminService: IAdminService
    {
        AdminRepository _repository = new AdminRepository();
        public bool SetCSCInitiative(tbCSCInitiative cscini)
        {
            return _repository.SetCSCInitiative(cscini);
        }
        public bool SetCSCInitiativeTeam(tbCSCInitiativeTeam csciniteam)
        {
            return _repository.SetCSCInitiativeTeam(csciniteam);
        }
        public bool SetRoute(tbCabRoute cabroute)
        {
            return _repository.SetRoute(cabroute);
        }
        public bool RegisterToCSCInitiativeTeam(String TeamID, String EmpID)
        {
            return _repository.RegisterToCSCInitiativeTeam(TeamID, EmpID);
        }

        public bool RegisterToCSCInitiative(String CSCInitiativeID, String EmpID)
        {
            return _repository.RegisterToCSCInitiative(CSCInitiativeID, EmpID);
        }
        public bool ApproveCab(String CabRegistrationId)
        {
            return _repository.ApproveCab(CabRegistrationId);
        }
    }
}
