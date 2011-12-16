<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<script type="text/javascript">
    $(document).ready(function () {
        jQuery("#DreamTable").jqGrid({
            url: '/Dream/DreamGridData',
            datatype: "json",
            colNames: ['DreamId', 'DreamTitle', 'DreamDescription', 'EmpId', 'EmpName', 'Building', 'SubmittedDate', 'Status', 'ContactPerson'],
            colModel: [
   		{ name: 'DreamId', index: 'DreamId', width: 20 },
   		{ name: 'DreamTitle', index: 'DreamTitle', width: 50 },
        { name: 'DreamDescription', index: 'DreamDescription', width: 150 },
        { name: 'EmpId', index: 'EmpId', width: 50 },
   		{ name: 'EmpName', index: 'EmpName', width: 50 },
        { name: 'Location', index: 'Location', width: 150 },
        { name: 'SubmittedDate', index: 'SubmittedDate', width: 50 },
        { name: 'Status', index: 'Status', width: 50 },
        { name: 'ContactPerson', index: 'ContactPerson', width: 70 }
   	],
            rowNum: 10,
            rowList: [10, 20, 30],
            width: 900,
            height: 300,
            pager: '#DreamTablePager',
            sortname: 'id',
            viewrecords: true,
            sortorder: "desc",
            caption: "Data",
            onSelectRow: function (id) {
               // alert(id);
                var data1 = "id=" + id;

             //   alert(data1);
                $.ajax({
                    url: '/Dream/DreamFormBind',
                    type: 'get',
                    data: data1,
                    dataType: "json",
                    data: data1,
                    async: false,
                    success: function (data) {
                        $("#DreamId").val(data[0].DreamId);
                        $("#DreamTitle").val(data[0].DreamTitle);
                        $("#DreamDescription").val(data[0].DreamDescription);
                        $("#ContactPerson").val(data[0].ContactPerson);
                        $("#Status").val(data[0].Status);
                       
                      //  alert(data[0].DreamTitle + "done.");
                    }
                });
            }
            ,
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
        jQuery("#DreamTable").jqGrid('navGrid', '#DreamTablePager', { edit: false, add: false, del: false });

    });
   
    </script>
   
    <table id="DreamTable"></table>
<div id="DreamTablePager"></div>