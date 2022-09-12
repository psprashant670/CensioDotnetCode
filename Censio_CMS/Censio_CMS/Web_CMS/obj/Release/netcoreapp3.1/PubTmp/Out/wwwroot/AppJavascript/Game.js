function AddEdit() {

    var formData = new FormData();
    formData.append('uploads', $('#file')[0].files[0]);
    formData.append('Id', $("#Id").val());
    formData.append('IdGame', $("#IdGame").val());
    formData.append('GameName', $("#GameName").val());
    formData.append('Status', $("#Status").val());
    formData.append("MapImgUrl", $("#MapImgUrl").val());
    $.ajax({

        type: 'POST',
        url: $('head base').attr('href') + 'Game/AddEdit',
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
                        window.location.href = $('head base').attr('href') + "Game/Create";
                    }
                    else {
                        window.location.href = $('head base').attr('href') + "Game/Index";
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

    function show(input) {
        if (input.files && input.files[0]) {
            var filerdr = new FileReader();
            filerdr.onload = function (e) {
                $('#map_img').attr('src', e.target.result);
            }
            filerdr.readAsDataURL(input.files[0]);
        }
    }
}
function Autofilltext() {
    $("#GameName").val($("#IdGame option:selected").text());
}
function clear() {
    $("#Id").val('');
    $("#IdGame").val('');
    $("#GameName").val('');
    $("#Status").val('');
    $('#map_img').attr('src', $("#MapImgUrl").val());
    $("#MapImgUrl").val('');

}
function Close() {
    $('#popupmodal').modal('hide');
    window.location.href = $('head base').attr('href') + "Game/Index";
}

