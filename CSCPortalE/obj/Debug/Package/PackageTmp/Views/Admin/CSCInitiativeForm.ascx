<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<CSCPortalE.tbCSCInitiative>"  %>

    <%using (Html.BeginForm())
      { %>
      <div class="tableformat">
    <div class="editor-label"><%: Html.LabelFor(model => model.CSCInitiativeName)%></div>
   <div class="editor-field"> <%: Html.TextBox("CSCInitiativeName")%></div>
   
    <div class="editor-label"><%: Html.LabelFor(model => model.Location)%></div>
    <div class="editor-field"><%: Html.TextBox("Location")%>
    </div>
      <div class="editor-label"><%: Html.LabelFor(model => model.DLID)%></div>
    <div class="editor-field"><%: Html.TextBox("DLID")%>
    </div>
      <div class="editor-label"><%: Html.LabelFor(model => model.HomePage)%></div>
    <div class="editor-field"><%: Html.TextBox("HomePage")%>
    </div>
     <div class="editor-label"><%: Html.LabelFor(model => model.Location)%></div>
    <div class="editor-field"><%: Html.TextBox("Location")%>
    </div>
     <div class="editor-label"><%: Html.LabelFor(model => model.CreatedDate)%></div>
    <div class="editor-field"><%: Html.TextBox("CreatedDate")%>
    </div>
    <input type="submit" value="Submit" />
    <%} %>
    </div>