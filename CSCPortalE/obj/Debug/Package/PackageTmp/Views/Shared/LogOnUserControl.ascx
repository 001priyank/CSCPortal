<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%
    if (Request.IsAuthenticated) {
%>
        Welcome <b><%: Page.User.Identity.Name %></b>!
        [ <%: Html.ActionLink("Log Off", "LogOff", "Account") %> ]
        <a href="https://meme.hcl.com/pages/one_dream/180"> [MEME]</a>
<%
    }
    else {
%> 
        [ <%: Html.ActionLink("Log On to Submit Your Dream", "LogOn", "Account") %> ]
<%
    }
%>
