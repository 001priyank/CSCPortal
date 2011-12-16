<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<script type="text/javascript">
    $(document).ready(function () {
        $("#RegisterToCSCInitiative").click(function () {


            //   $.ajax({
            //      url: '/Admin/RegisterToCSCInitiative',
            //     type: 'get',
            //    data: data1,
            //   dataType: "json",
            //  data: data1,
            //  async: false,
            //  success: function () {
            //     alert("done");
            // }
            //  });

        });
        jQuery("#CSCInitiative").jqGrid({
            url: '/GridData/getCSCInitiativeGridDisplayResult',
            datatype: "json",
            colNames: ['CSCInitiativeID', 'CSCInitiativeName', 'Location', 'HomePage', 'DLID', 'CreatedDate', 'Register'],
            colModel: [
   		{ name: 'CSCInitiativeID', index: 'CSCInitiativeID', width: 100 },
   		{ name: 'CSCInitiativeName', index: 'CSCInitiativeName', width: 150 },
        { name: 'Location', index: 'Location', width: 150 },
        { name: 'HomePage', index: 'HomePage', width: 150 },
   		{ name: 'DLID', index: 'DLID', width: 150 },
        { name: 'CreatedDate', index: 'CreatedDate', width: 100 },
        { name: 'Register', index: 'Register', width: 100 },

   	],
            rowNum: 10,
            rowList: [10, 20, 30],
            pager: '#CSCInitiativePager',
            sortname: 'id',
            viewrecords: true,
            sortorder: "desc",
            caption: "Data",
            ondblClickRow: function (rowid) {
                var data1 = "TeamID=" + rowid;
                //  alert(data1);
                $.ajax({
                    url: '/Admin/RegisterToCSCInitiative',
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
        jQuery("#CSCInitiative").jqGrid('navGrid', '#CSCInitiativePager', { edit: false, add: false, del: false });

    });
    </script>
    
    <a id="RegisterToCSCInitiative" href="javascipt:void(0)">Register</a>
    <table id="CSCInitiative"></table>
<div id="CSCInitiativePager"></div>
    