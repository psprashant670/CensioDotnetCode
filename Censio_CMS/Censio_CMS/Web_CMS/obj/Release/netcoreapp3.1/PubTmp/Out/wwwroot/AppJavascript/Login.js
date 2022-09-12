function Login() {

   
    var formData = new FormData();
    formData.append("Email", $("#username").val());
    formData.append("Password", $("#Password").val());
   
    $.ajax({

        type: 'POST',
        url: $('head base').attr('href') + "Login/UserLogins",
        data: formData,
        cache: false,
        contentType: false,
        processData: false,
        success: function (response) {
            var myhtml = '';
           
            if (response.data == 1) {

                window.location.href = $('head base').attr('href') + "Home/Index";
            }

            else {
                myhtml = '<div  style=" text-align: center;" class="alert alert-danger"> <strong>Info! ' + response.message + '</strong></div>';
            }
            $("#myAlert").html(myhtml);
            $("#myAlert").fadeIn(500).delay(3000).fadeOut(1000);
        }

    });
    return false; 
}

