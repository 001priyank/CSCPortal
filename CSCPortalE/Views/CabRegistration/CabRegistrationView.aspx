<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	CabRegistrationView
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
 <script type="text/javascript">
     $(document).ready(function () {
         jQuery("#CabTable").jqGrid({
             url: '/CabRegistration/CabRegistrationGridData',
             datatype: "json",
             colNames: ['EmpID', 'CabRegistrationID', 'CSCInititative', 'CabRoute', 'CabRegistrationDate', 'Status'],
             colModel: [
   		{ name: 'EmpID', index: 'EmpID', width: 100 },
   		{ name: 'CabRegistrationID', index: 'CabRegistrationID', width: 150 },
        { name: 'CSCInititative', index: 'CSCInititative', width: 150 },
        { name: 'CabRoute', index: 'CabRoute', width: 150 },
   		{ name: 'CabRegistrationDate', index: 'CabRegistrationDate', width: 150 },
        { name: 'Status', index: 'Status', width: 150 }


   	],
             rowNum: 10,
             rowList: [10, 20, 30],
             pager: '#CabTablePager',
             sortname: 'id',
             viewrecords: true,
             sortorder: "desc",
             caption: "Data",
             ondblClickRow: function (rowid) {
                 var data1 = "id=" + rowid;
                 //  alert(data1);
                 $.ajax({
                     url: '/Admin/ApproveCab',
                     type: 'get',
                     data: data1,
                     dataType: "json",
                     data: data1,
                     async: false,
                     success: function () {
                         alert("Approval done.");
                     }
                 });
             }
         });
         jQuery("#CabTable").jqGrid('navGrid', '#CabTablePager', { edit: false, add: false, del: false });

     });
   
    </script>
    <h2></h2>
    <table id="CabTable"></table>
<div id="CabTablePager"></div>


</asp:Content>
