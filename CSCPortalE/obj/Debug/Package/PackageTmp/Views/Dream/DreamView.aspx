<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site2.Master" Inherits="System.Web.Mvc.ViewPage<CSCPortalE.Models.DreamGridDisplayModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	DreamView
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

         <div id="DreamGrid">
                <% Html.RenderPartial("DreamGrid"); %>
      </div> 

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

         <div id="Div1">
                 
            <!--      <% Html.RenderPartial("DreamUserView"); %> -->
                 <%using (Html.BeginForm())
      { %>
      <div class="tableformat">
    
    <div><%: Html.Hidden("DreamId", Model.DreamId)%>
   
    <p><div class="editor-label fontClass" ><%: Html.LabelFor(model => model.DreamTitle)%></div>
    <div class="editor-field "><%: Html.TextBox("DreamTitle", Model.DreamTitle, new { @readonly = "true" })%>
    </div>
    </p>
 
      <div class="editor-label fontClass"><%: Html.LabelFor(model => model.DreamDescription)%></div>
    <div class="editor-field"><%: Html.TextArea("DreamDescription", Model.DreamDescription, 10, 60, new { @readonly = "true" })%>
    </div>
  
        <%if(HttpContext.Current.User.IsInRole("Administrator")){ %>
      <%: Html.LabelFor(model => model.ContactPerson)%></div>
    <%: Html.TextBox("ContactPerson")%>
     <%: Html.LabelFor(model => model.Status)%>
    <%: Html.TextBox("Status")%>
    
    <input type="submit" value="Submit" />
    </div>
     <%} %>
    <%} %>
    </div>
      </div> 

</asp:Content>
