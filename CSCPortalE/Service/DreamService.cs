using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSCPortalE.repository;
using CSCPortalE.Models;

namespace CSCPortalE.Service
{
    public class DreamService
    {
        public List<CSCPortalE.Models.DreamGridDisplayModel> DreamGridDisplay()
        {
           GridDataRepository  _repository = new GridDataRepository();
           var returnToGrid = _repository.getDreamGridDisplayResult();
            return returnToGrid;

        }
        public bool DreamFormSubmit(tbDream dreamTable)
        { 
           
           var _repository=new DreamRepository();
                    
           return _repository.DreamFormSubmit(dreamTable);
            
        
        }

        public List<DreamGridDisplayModel> DreamFormBind(String DreamId)
        {
            var _repository = new DreamRepository();
            var modelData = _repository.DreamFormBind(DreamId);
            var modelDataToReturn = (from data in modelData
                                     select new DreamGridDisplayModel
                                     { DreamId=data.DID,
                                         DreamTitle=data.DTITLE,
                                         DreamDescription=data.DDESCRIPTION,
                                         ContactPerson=data.CONTACTPERSON,
                                         Status=data.STATUSID.GetValueOrDefault().ToString()
                                     }
                                   );
            return modelDataToReturn.ToList();
        }
        public bool DreamFormUpdate(DreamGridDisplayModel dreamModel)
        {
            var _repository=new DreamRepository();
                  
           return _repository.DreamFormUpdate(dreamModel);
            
        }

    }

}