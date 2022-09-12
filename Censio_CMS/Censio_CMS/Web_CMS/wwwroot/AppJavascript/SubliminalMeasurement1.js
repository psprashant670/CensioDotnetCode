function AddEdit() {

    var formData = new FormData();
    formData.append('IdSubliminalMeasurement1', $("#IdSubliminalMeasurement1").val());
    formData.append('IdGame', $("#IdGame").val());
    formData.append('IdBehavior', $("#IdBehavior").val());
    formData.append('SubliminalMeasurementName', $("#SubliminalMeasurementName").val());
    formData.append('BehaviorScore', $("#BehaviorScore").val());
    formData.append('Status', $("#Status").val());
    $.ajax({

        type: 'POST',
        url: $('head base').attr('href') + 'SubliminalMeasurement1/AddEdit',
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
                        window.location.href = $('head base').attr('href') + "SubliminalMeasurement1/Create";
                    }
                    else {
                        window.location.href = $('head base').attr('href') + "SubliminalMeasurement1/Index";
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

function clear() {
    $("#IdSubliminalMeasurement1").val('');
    $("#IdGame").val('');
    $("#IdBehavior").val('');
    $("#SubliminalMeasurementName").val('');
    $("#BehaviorScore").val('');
    $("#Status").val('');
}
function Close() {
    $('#popupmodal').modal('hide');
    window.location.href = $('head base').attr('href') + "SubliminalMeasurement1/Index";
}

