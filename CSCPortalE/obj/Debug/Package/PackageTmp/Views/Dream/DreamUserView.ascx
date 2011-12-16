<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CSCPortalE.Models.DreamGridDisplayModel>" %>
 <%using (Html.BeginForm())
      { %>
      <div class="tableformat">
    
   
    <p><div class="editor-label fontClass" ><%: Html.LabelFor(model => model.DreamTitle)%></div>
    <div class="editor-field "><%: Html.TextBox("DreamTitle", Model.DreamTitle, new { @readonly = "true" })%>
    </div>
    </p>
 
      <div class="editor-label fontClass"><%: Html.LabelFor(model => model.DreamDescription)%></div>
    <div class="editor-field"><%: Html.TextArea("DreamDescription", Model.DreamDescription, 10, 20, new { @readonly = "true" })%>
    </div>
  
        <%if(HttpContext.Current.User.IsInRole("Administrator")){ %>
        <div class="editor-label fontClass" ><%: Html.LabelFor(model => model.ContactPerson)%></div>
    <div class="editor-field "><%: Html.TextBox("ContactPerson", Model.ContactPerson)%>
    </div>
    <input type="submit" value="Submit" />
     <%} %>
    <%} %>
    </div>

