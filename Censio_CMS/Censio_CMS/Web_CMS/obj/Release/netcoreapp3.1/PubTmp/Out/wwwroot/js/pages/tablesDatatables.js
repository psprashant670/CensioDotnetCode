/*
 *  Document   : tablesDatatables.js
 *  Author     : pixelcave
 *  Description: Custom javascript code used in Tables Datatables page
 */

var TablesDatatables = function() {

    return {
        init: function() {
            /* Initialize Bootstrap Datatables Integration */
            App.datatables();

            /* Initialize Datatables */
            $('#example-datatable').dataTable({
                columnDefs: [ { orderable: false, targets: [3 ] } ],
                pageLength: 10,
                lengthMenu: [[10, 50, 100, 500, -1], [10, 50, 100, 500, 'All']],
                
            });
            $('#userwiseotherobjecttable').dataTable({
                columnDefs: [{ targets:6, className: "truncate" }],
                createdRow: function (row) {
                    $(row).find(".truncate").each(function () {
                        $(this).attr("title", this.innerText);
                    });
                }

            });
            $('#otherobjecttable').dataTable({
                columnDefs: [{ targets:5, className: "truncate" }],
                createdRow: function (row) {
                    $(row).find(".truncate").each(function () {
                        $(this).attr("title", this.innerText);
                    });
                }

            });
            
            $('#GameChallengelevel').dataTable({
                columnDefs: [{ targets:6, className: "truncate" }],
                createdRow: function (row) {
                    $(row).find(".truncate").each(function () {
                        $(this).attr("title", this.innerText);
                    });
                }

            });
            
           
            
            
           
            $('body').on('change', '#checkboxbtn', function () {
                var rows, checked;
                rows = $('#example').find('tbody tr');
                checked = $(this).prop('checked');
                $.each(rows, function () {
                    var checkbox = $($(this).find('td').eq(0)).find('input').prop('checked', checked);
                });
            });
            /* Add placeholder attribute to the search input */
            $('.dataTables_filter input').attr('placeholder', 'Search');

            $('thead input:checkbox').click(function () {
                var checkedStatus = $(this).prop('checked');
                var table = $(this).closest('table');

                $('tbody input:checkbox', table).each(function () {
                    $(this).prop('checked', checkedStatus);
                });
            });
        }
    };
}();

 