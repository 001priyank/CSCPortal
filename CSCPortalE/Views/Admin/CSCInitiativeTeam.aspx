<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CSCPortalE.tbCSCInitiativeTeam>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div id="CSCInitiativeTeamGrid">
                <% Html.RenderPartial("CSCInitiativeTeamGrid"); %>
      </div> 
        <%if(HttpContext.Current.User.IsInRole("Administrator")){ %>
     <div id="CSCInitiativeTeamForm">
                <% Html.RenderPartial("CSCInitiativeTeamForm"); %>
      </div> 
        <%} %>
</asp:Content>
