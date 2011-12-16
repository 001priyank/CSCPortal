using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSCPortalE.repository;
using CSCPortalE.Models;

namespace CSCPortalE.Service
{
    public class GridDataService
    {
        public List<CSCInitiativeGridDisplayModel> getCSCInitiativeGridDisplayResult()
        {
            var  _repository = new GridDataRepository();
            var returnToGrid = _repository.getCSCInitiativeGridDisplayResult();
            return returnToGrid;

        }
        public List<CSCInitiativeTeamGridDisplayModel> getCSCInitiativeTeamGridDisplayResult()
        {
            var _repository = new GridDataRepository();
            var returnToGrid = _repository.getCSCInitiativeTeamGridDisplayResult();
            return returnToGrid;

        }
    }
}