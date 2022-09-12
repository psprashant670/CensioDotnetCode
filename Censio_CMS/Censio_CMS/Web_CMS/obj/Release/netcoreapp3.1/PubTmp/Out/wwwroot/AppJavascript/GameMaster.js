﻿function AddEdit() {

    var formData = new FormData();
    formData.append('IdGame', $("#IdGame").val());
    formData.append('GameName', $("#GameName").val());
   

    $.ajax({

        type: 'POST',
        url: $('head base').attr('href') + 'GameMaster/AddEdit',
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
                        window.location.href = $('head base').attr('href') + "GameMaster/Create";
                    }
                    else {
                        window.location.href = $('head base').attr('href') + "GameMaster/Index";
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
    $("#IdGame").val('');
    $("#GameName").val('');
 
}
function Close() {
    $('#popupmodal').modal('hide');
    window.location.href = $('head base').attr('href') + "GameMaster/Index";
}

