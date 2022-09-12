
function AddEdit() {

    var formData = new FormData();
    formData.append('uploads', $('#file')[0].files[0]);
    formData.append("IdAvatar", $("#IdAvatar").val());
    formData.append("Url", $("#Url").val());
    formData.append("IsActive", $("#IsActive").val());
   

    $.ajax({

        type: 'POST',
        url: $('head base').attr('href') + 'Avatar/AddEdit',
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
                        window.location.href = $('head base').attr('href') + "Avatar/Create";
                    }
                    else {
                        window.location.href = $('head base').attr('href') + "Avatar/Index";
                    }
                }
                else {
                    myhtml = '<div  style=" text-align: center;" class="alert-danger"><strong>Danger!</strong> ' + response.message + '</div>';
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

function show(input) {
  
    if (input.files && input.files[0]) {
        var filerdr = new FileReader();
        filerdr.onload = function (e) {
            $('#url_img').attr('src', e.target.result);
        }
        filerdr.readAsDataURL(input.files[0]);
    }
}

function clear() {

    $("#IdAvatar").val('');
    $("#Url").val('');
    $("#IsActive").val('');
    $('#url_img').attr('src', $("#Url").val());
}
function Close() {
    $('#popupmodal').modal('hide');
    window.location.href = $('head base').attr('href') + "Avatar/Index";
}

