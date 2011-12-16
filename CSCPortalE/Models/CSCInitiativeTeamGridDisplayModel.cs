using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSCPortalE.Models
{
    public class CSCInitiativeTeamGridDisplayModel
    {
        public int CSCInitiativeID 
        {get;set;}
        public String CSCInitiativeName
        { get; set; }
        public String TeamName
        {get;set;}
        public String  EmpID 
        {get;set;}
         public String Location
         {get;set;}
         public String HomePage
         {get;set;}
         public String  DLID
         {get;set;}
         public DateTime  CreatedDate
         {get;set;}
         public String TeamID
         { get; set; }
    }

    public class DreamGridDisplayModel
    {
       //To be used later
        public int DreamId
        { get; set; }
        public String DreamTitle
        { get; set; }
        public String DreamDescription
        { get; set; }
        public String EmpId
        { get; set; }
        public String EmpName
        { get; set; }
        public String Location
        { get; set; }
        public String SubmittedDate
        { get; set; }
        public String Status
        { get; set; }
        public String ContactPerson
        { get; set; }
        
    }

}