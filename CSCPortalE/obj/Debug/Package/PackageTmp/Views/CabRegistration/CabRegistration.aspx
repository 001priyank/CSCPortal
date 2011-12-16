<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CSCPortalE.Models.CabModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">

    CabRegistration

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript">
    $(document).ready(function () {
        $("#Submit").click(function () {
           
            var data1= "CSCInitiativeID="+ $("#CSCInitiativeID option:selected").val()+
                "&CSCInitiativeTeams="+ $("#CSCInitiativeTeams option:selected").val()+
                    "&CabRouteID="+ $("#CabRouteID option:selected").val()+
                    "&EnterDate="+ $("#EnterDate").val();
              
            $.ajax({
                url: '/CabRegistration/CabRegistrationSubmit',
                type: 'get',
                data: data1,
                dataType: "json",
                data: data1,
                async:false,
                success: function () {
                    alert("done");
                }
            });
            alert("Cab Registered.");

        });

    });
</script>


    <h2></h2>
    <%using(Html.BeginForm()){ %>
    <div class="tableformat">
     <div class="editor-label">Emp ID</div><div class="editor-field"><%: Html.TextBox("EmpID", Model.EmpID, new { @readonly="true"})%></div>
    <div class="editor-label">CSCIntitiative</div>
      <div class="editor-field"><%: Html.DropDownList("CSCInitiativeID", CSCPortalE.Service.CabRegistrationService.getCSCIntitiatives())%></div>

     <div class="editor-label">CSCIntitiativeTeams</div>
    <div class="editor-field"> <%: Html.DropDownList("CSCInitiativeTeams", CSCPortalE.Service.CabRegistrationService.getCSCIntitiativeTeams())%></div>
      <div class="editor-label">Pickup Point</div><div class="editor-field"><%: Html.DropDownList("CabRouteID", CSCPortalE.Service.CabRegistrationService.getRoutes())%></div>
       <div class="editor-label">Enter Date</div> <div class="editor-field"><%: Html.TextBox("EnterDate")%></div>
        <input type="button" id="Submit" value="Submit" />
         <p><%} %></p>
         </div>

</asp:Content>