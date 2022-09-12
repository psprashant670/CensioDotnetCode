function AddEdit() {

    var formData = new FormData();

    formData.append("IdGuideDialogues", $("#IdGuideDialogues").val());
    formData.append("IdGame", $("#IdGame").val());
    formData.append("GuideDialogue", $("#GuideDialogue").val());
    formData.append("GuideIntroMessage", $("#GuideIntroMessage").val());
    formData.append("TypeDialogue", $("#TypeDialogue").val());
    formData.append("TypeDialogueName", $("#TypeDialogueName").val());
    formData.append("Sequence", $("#Sequence").val());
    formData.append("IsActive", $("#IsActive").val());
    

    $.ajax({

        type: 'POST',
        url: $('head base').attr('href') + 'GuideDialogues/AddEdit',
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
                        window.location.href = $('head base').attr('href') + "GuideDialogues/Create";
                    }
                    else {
                        window.location.href = $('head base').attr('href') + "GuideDialogues/Index";
                    }
                }
                else {
                    myhtml = '<div  style=" text-align: center;" class="alert-danger"><strong></strong> ' + response.message + '</div>';
                }
                $("#myAlert").html(myhtml);
                $("#myAlert").fadeIn(500).delay(3000).fadeOut(1000);
                $("#myAlert2").html(myhtml);
                $("#myAlert2").fadeIn(500).delay(3000).fadeOut(1000);
                $('.loader').hide();
                $('#btn').prop("disabled", false);

            }
            else {
                alert("Error");
            }
        }
    });
}

function clear() {


    $("#IdGuideDialogues").val('');
    $("#IdGame").val('');
    $("#GuideDialogue").val('');
    $("#GuideIntroMessage").val('');
    $("#TypeDialogue").val('');
    $("#TypeDialogueName").val('');
    $("#Sequence").val('');
    $("#IsActive").val('');
   


}
function Close() {
    $('#popupmodal').modal('hide');
    window.location.href = $('head base').attr('href') + "GuideDialogues/Index";
}