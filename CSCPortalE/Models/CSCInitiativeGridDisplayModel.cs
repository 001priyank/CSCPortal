using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSCPortalE.Models
{
    public class CSCInitiativeGridDisplayModel
    {
       public int  CSCInitiativeID {get;set;}
       public String CSCInitiativeName {get;set;}
       public String  Location {get;set;}
       public String  HomePage {get;set;}
       public String   DLID {get;set;}
       public DateTime CreatedDate { get; set; }
        
    }
}