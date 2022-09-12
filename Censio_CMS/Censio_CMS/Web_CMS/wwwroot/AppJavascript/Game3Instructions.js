function Close() {
    $('#popupmodal').modal('hide');
    window.location.href = $('head base').attr('href') + "Game3Instructions/Index";
}
function clear() {


    $("#IdInstruction").val('');
    $("#FestivalName").val('');
    $("#InstructionPostion").val('');
    $("#InstructionSequence").val('');
    $("#InstructionText").val('');
    $("#InstructionImagepath").val('');
    $("#Status").val('');


}

function AddEdit() {

    var formData = new FormData();
    formData.append("IdGameInstructionLog", $("#IdGameInstructionLog").val());
    formData.append("IdInstruction", $("#IdInstruction").val());
    formData.append("FestivalName", $("#FestivalName").val());
    formData.append("InstructionPostion", $("#InstructionPostion").val());
    formData.append("InstructionSequence", $("#InstructionSequence").val());
    formData.append("InstructionText", $("#InstructionText").val());
    formData.append("InstructionImagepath", $("#InstructionImagepath").val());
    formData.append("Status", $("#Status").val());




    //var ObjectLists = [];
    //$("#idbehavior option:selected").each(function () {

    //    var Value = $(this).val();
    //    Idbehavior = [

    //        Value,
    //    ]
    //    ObjectLists.push(Idbehavior);

    //});
    //formData.append("Game5Behaviors", ObjectLists.toString());

    $.ajax({
        type: 'POST',
        url: $('head base').attr('href') + 'Game3Instructions/AddEdit',
        data: formData,
        cache: false,
        contentType: false,
        processData: false,

        beforeSend: function () {
            $("#btn").attr("disabled", "true");
            $('.loader').show();


        },
        success: function (response) {

            if (response != '') {
                var myhtml = '';
                if (response.data == 1 || response.data == 2) {
                    myhtml = '<div style=" text-align: center;" class="alert alert-success"><strong>Success!</strong> ' + response.message + '</div>';
                    clear();
                    if (response.data == 2) {
                        window.location.href = $('head base').attr('href') + "Game3Instructions/Index";
                    }
                    else {
                        window.location.href = $('head base').attr('href') + "Game3Instructions/Index";
                    }
                    $("#myAlert").html(myhtml);
                    $("#myAlert").fadeIn(500).delay(3000).fadeOut(1000);
                    $("#myAlert2").html(myhtml);
                    $("#myAlert2").fadeIn(500).delay(3000).fadeOut(1000);
                    $('.loader').hide();
                    $('#btn').prop("disabled", false);
                }
                else {

                    myhtml = '<div  style=" text-align: center;" class="alert-danger"><strong></strong> ' + response.message + '</div>';
                    $("#myAlert").html(myhtml);
                    $("#myAlert").fadeIn(5000).delay(30000).fadeOut(10000);
                    $("#myAlert2").html(myhtml);
                    $("#myAlert2").fadeIn(5000).delay(30000).fadeOut(10000);
                    $('.loader').hide();
                    $('#btn').prop("disabled", false);
                }


            }
            else {
                alert("Error");
            }
        }
    });
}