
function AddEdit() {

    var formData = new FormData();
    formData.append('uploads', $('#file')[0].files[0]);
    formData.append("IdOrganization", $("#IdOrganization").val());
    formData.append("OrganizationName", $("#OrganizationName").val());
    formData.append("Description", $("#Description").val());
    formData.append("Logo", $("#Logo").val());
    formData.append("Name", $("#Name").val());
    formData.append("PhoneNo", $("#PhoneNo").val());
    formData.append("ContactEmail", $("#ContactEmail").val());
    formData.append("DefaultEmail", $("#DefaultEmail").val());
    formData.append("Status", $("#Status").val());
   
    $.ajax({

        type: 'POST',
        url: $('head base').attr('href') + 'Organization/AddEdit',
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
                        window.location.href = $('head base').attr('href') + "Organization/Create";
                    }
                    else {
                        window.location.href = $('head base').attr('href') + "Organization/Index";
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
            $('#user_img').attr('src', e.target.result);
        }
        filerdr.readAsDataURL(input.files[0]);
    }
}





function clear() {
    document.getElementById('file').value = ''
    $("#IdOrganization").val('');
    $("#OrganizationName").val('');
    $("#Description").val('');
    $("#Logo").val('');
    $("#Name").val('');
    $("#PhoneNo").val('');
    $("#ContactEmail").val('');
    $("#DefaultEmail").val('');
    $('#user_img').attr('src', $("#Logo").val());
    $("#Status").val('');
   
}
function Close() {
    $('#popupmodal').modal('hide');
    window.location.href = $('head base').attr('href') + "Organization/Index";
}

