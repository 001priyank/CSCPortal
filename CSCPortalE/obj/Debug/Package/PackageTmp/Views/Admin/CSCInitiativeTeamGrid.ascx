<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<script src="../../Scripts/js/Grid.js" type="text/javascript"></script>
<script type="text/javascript">
    $(document).ready(function () {


        jQuery("#CSCInitiativeTeam").jqGrid({
            url: '/GridData/getCSCInitiativeTeamGridDisplayResult',
            datatype: "json",
            colNames: ['CSCInitiativeID', 'TeamID', 'TeamName', 'Location', 'HomePage', 'DLID', 'CreatedDate', 'EmpID','CSCInitiativeName'],
            colModel: [
   		{ name: 'CSCInitiativeID', index: 'CSCInitiativeID', width: 100, hidden: true },
   		{ name: 'TeamID', index: 'TeamID', width: 150, hidden: true },
        { name: 'TeamName', index: 'TeamName', width: 150 },

        { name: 'Location', index: 'Location', width: 150 },
        { name: 'HomePage', index: 'HomePage', width: 150 },
   		{ name: 'DLID', index: 'DLID', width: 150 },
        { name: 'CreatedDate', index: 'CreatedDate', width: 100 },
        { name: 'EmpID', index: 'EmpID', width: 100 },
        { name: 'CSCInitiativeName', index: 'CSCInitiativeName', width: 100 }

   	],
            rowNum: 10,
            rowList: [10, 20, 30],
            pager: '#CSCInitiativeTeamPager',
            sortname: 'id',
            viewrecords: true,
            sortorder: "desc",
            caption: "Data",
            ondblClickRow: function (rowid) {
               
                var data1 = "TeamID=" + rowid;
                //  alert(data1);
                $.ajax({
                    url: '/Admin/RegisterToCSCInitiativeTeam',
                    type: 'get',
                    data: data1,
                    dataType: "json",
                    data: data1,
                    async: false,
                    success: function () {
                        alert("Registration done");
                    }
                });

            }

        });
        jQuery("#CSCInitiativeTeam").jqGrid('navGrid', '#CSCInitiativeTeamPager', { edit: false, add: false, del: false });

    });
    </script>
    <h2></h2>
    <a id="RegisterToCSCInitiativeTeam" href="javascipt:void(0)">Register</a>
    <table id="CSCInitiativeTeam"></table>
<div id="CSCInitiativeTeamPager"></div>
    