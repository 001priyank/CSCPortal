<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CSCPortalE.tbCSCInitiativeTeam>" %>
<h2>CSCInitiativeTeam</h2>
       <%using (Html.BeginForm())
       { %>
       <div class="tableformat">
         <div class="editor-label"><%: Html.LabelFor(model => model.TeamName)%></div>
        <div class="editor-field"> <%: Html.TextBox("TeamName")%></div>
       <div class="editor-label">CSCIntitiative</div>
       <div class="editor-field"><%: Html.DropDownList("CSCInitiativeID", CSCPortalE.Service.CabRegistrationService.getCSCIntitiatives())%></div>

      <div class="editor-label"><%: Html.LabelFor(model => model.EmpID)%></div>
      <div class="editor-field"> <%: Html.TextBox("EmpID") %></div>
      
       <div class="editor-label"><%: Html.LabelFor(model => model.DLID)%></div>
   <div class="editor-field"> <%: Html.TextBox("DLID")%></div>
    
    <div class="editor-label"><%: Html.LabelFor(model => model.HomePage)%></div>
    <div class="editor-field"><%: Html.TextBox("HomePage")%></div>
    
     <div class="editor-label"><%: Html.LabelFor(model => model.Location)%></div>
   <div class="editor-field"> <%: Html.TextBox("Location")%></div>
    
     <div class="editor-label"><%: Html.LabelFor(model => model.CreatedDate)%></div>
   <div class="editor-field"> <%: Html.TextBox("CreatedDate")%></div>
    
   
       <div class="editor-label">IsSPOC</div><div class="editor-field"><%: Html.DropDownList("IsSPOC", CSCPortalE.Service.CabRegistrationService.getCSCInitiativeTeamIsSPOC())%></div>
      <input type="submit" value="Submit" />
      <%} %>
      </div>