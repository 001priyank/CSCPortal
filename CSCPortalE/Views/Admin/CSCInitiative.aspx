<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CSCPortalE.tbCSCInitiative>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div id="CSCInitiativeGrid">
                <% Html.RenderPartial("CSCInitiativeGrid"); %>
      </div> 
         <%if(HttpContext.Current.User.IsInRole("Administrator")){ %>
     <div id="CSCInitiativeForm">
                <% Html.RenderPartial("CSCInitiativeForm"); %>
      </div> 
       <%} %>

</asp:Content>
