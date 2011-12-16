<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CSCPortalE.tbEmp>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    
    <div class="tableformat">
    <%using(Html.BeginForm()) { %>
   <div class="editor-label">
    <%: Html.LabelFor(model => model.EmpID) %>
    </div>
    <div class="editor-field">
    <%: Html.TextBox("EmpID", Model.EmpID, new { @readonly="true"})%>
      </div>

     <div class="editor-label">
   <%: Html.LabelFor(model => model.EmpName) %>
   </div>
   <div class="editor-field">
    <%: Html.TextBox("EmpName",Model.EmpName)%>
    </div>
  
    <div class="editor-label">
   <!--<%: Html.LabelFor(model => model.Location) %> -->
   Building
   </div>
   <div class="editor-field">
    <%: Html.TextBox("Location",Model.Location)%>
   </div>
     <div class="editor-label">
   <%: Html.LabelFor(model => model.Email) %>
   </div>
   <div class="editor-field">
    <%: Html.TextBox("Email", Model.Email, new { @readonly = "true" })%>
   </div>
     <div class="editor-label">
   <%: Html.LabelFor(model => model.Phone) %>
   </div>
   <div class="editor-field">
    <%: Html.TextBox("Phone",Model.Phone)%>
 </div>
   
    <p>
    <input type="submit" value="Submit" />
    </p>
    <%} %>
  
  </div>

</asp:Content>
