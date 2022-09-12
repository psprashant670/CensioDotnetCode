function AddEdit() {

    var formData = new FormData();
    formData.append('IdSubliminalMeasurement2', $("#IdSubliminalMeasurement2").val());
    formData.append('IdGame', $("#IdGame").val());
    formData.append('IdBehavior', $("#IdBehavior").val());
    formData.append('SubliminalMeasurement2Name', $("#SubliminalMeasurement2Name").val());
    formData.append('BehaviorScore', $("#BehaviorScore").val());
    formData.append('Status', $("#Status").val());
    formData.append('GameFeedbackMsg', $("#GameFeedbackMsg").val());
    formData.append("IdLevel", $("#IdLevel").val());
    $.ajax({

        type: 'POST',
        url: $('head base').attr('href') + 'SubliminalMeasurement2/AddEdit',
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
                        window.location.href = $('head base').attr('href') + "SubliminalMeasurement2/Create";
                    }
                    else {
                        window.location.href = $('head base').attr('href') + "SubliminalMeasurement2/Index";
                    }
                }
                else {
                    myhtml = '<div  style=" text-align: center;" class="alert-danger"><strong>Danger!</strong> ' + response.message + '</div>';
                }
                $("#myAlert").html(myhtml);
                $("#myAlert").fadeIn(500).delay(3000).fadeOut(1000);
                $('.loader').hide();
                $('#btn').prop("disabled", false);
            }
            else {
                alert("Error");
            }
        }
    });
}
function FillChallenge() {

    var Id_Game = $('#IdGame').val();
    $.ajax({
        url: $('head base').attr('href') + 'SubliminalMeasurement2/FillChallenge',
        type: "GET",
        dataType: "JSON",
        data: { idGame: Id_Game },
        success: function (Challenges) {
            $("#IdLevel").html("");
            $.each(Challenges, function (i, challenge) {
                $("#IdLevel").append(
                    $('<option></option>').val(challenge.idLevel).html(challenge.challengeName));
            });
        }
    });
}
function clear() {
    $("#IdSubliminalMeasurement2").val('');
    $("#IdGame").val('');
    $("#IdBehavior").val('');
    $("#SubliminalMeasurement2Name").val('');
    $("#BehaviorScore").val('');
    $("#Status").val('');
    $("#GameFeedbackMsg").val('');
    $("#IdLevel").val('');
}
function Close() {
    $('#popupmodal').modal('hide');
    window.location.href = $('head base').attr('href') + "SubliminalMeasurement2/Index";
}

