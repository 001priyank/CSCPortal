using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSCPortalE.Service
{
    interface IAdminService
    {
        bool SetCSCInitiative(tbCSCInitiative cscini);

        bool SetCSCInitiativeTeam(tbCSCInitiativeTeam csciniteam);
        bool SetRoute(tbCabRoute cabroute);
        
    }
}
