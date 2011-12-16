<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CSCPortalE.Models.DreamGridDisplayModel>" %>
 <%using (Html.BeginForm())
      { %>
      <div class="tableformat">
    
   
    <p><div class="editor-label fontClass" ><%: Html.LabelFor(model => model.DreamTitle)%></div>
    <div class="editor-field "><%: Html.TextBox("DreamTitle")%>
    </div>
    </p>
 
      <div class="editor-label fontClass"><%: Html.LabelFor(model => model.DreamDescription)%></div>
    <div class="editor-field"><%: Html.TextAreaFor(model => model.DreamDescription,8,40,null)%>
    </div>
  
    
    <input type="submit" value="Submit" />
    <%} %>
    </div>

