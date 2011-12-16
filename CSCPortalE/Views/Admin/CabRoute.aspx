<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CSCPortalE.tbCabRoute>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CabRoute
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>CabRoute</h2>
     <%using (Html.BeginForm())
      { %>
    <p><%: Html.LabelFor(model => model.CabRouteName)%>
    <%: Html.TextBox("CabRouteName")%>
    </p>
    <p>CSCIntitiative<%: Html.DropDownList("CSCInitiativeID", CSCPortalE.Service.CabRegistrationService.getCSCIntitiatives())%></p>
    <input type="submit" value="Submit" />
    <%} %>
</asp:Content>
