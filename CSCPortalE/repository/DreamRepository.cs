using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSCPortalE.Models;

namespace CSCPortalE.repository
{
    public class DreamRepository
    {
        public bool DreamFormSubmit(tbDream dreamTable)
        {
            var _dataContext = new CSCPortalDataContext();
            try
            {
                _dataContext.tbDreams.InsertOnSubmit(dreamTable);
                _dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public List<tbDream> DreamFormBind(String DreamId)
        {
            var _dataContext = new CSCPortalDataContext();
            try
            {
                var modelData = (from data in _dataContext.tbDreams
                                 where data.DID == int.Parse(DreamId)
                                 select data);
                return modelData.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
        public bool DreamFormUpdate(DreamGridDisplayModel dreamModel)
        {
            var _dataContext = new CSCPortalDataContext();
            try
            {
                var dreamModelData = (from data in _dataContext.tbDreams
                                      where data.DID == dreamModel.DreamId
                                      select data).FirstOrDefault();
                dreamModelData.CONTACTPERSON = dreamModel.ContactPerson;
                dreamModelData.STATUSID = int.Parse(dreamModel.Status);
                _dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        
    }
}