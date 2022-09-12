
function AddEdit() {
   
    var formData = new FormData();
    formData.append('Imagesfile', $('#Imagesfile')[0].files[0]);
    formData.append("Images", $("#Images").val());
    formData.append("IdPuzzle", $("#IdPuzzle").val());
    formData.append("IdLevel", $("#IdLevel").val());
    formData.append("RowColumn", $("#RowColumn").val());
    formData.append("AnswerSequence", $("#AnswerSequence").val());
    formData.append("Coins", $("#Coins").val());
    formData.append("IsActive", $("#IsActive").val());
    $.ajax({

        type: 'POST',
        url: $('head base').attr('href') + 'Game1PuzzleImg/AddEdit',
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
                        window.location.href = $('head base').attr('href') + "Game1PuzzleImg/Create";
                    }
                    else {
                        window.location.href = $('head base').attr('href') + "Game1PuzzleImg/Index";
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

function Imagesshow(input) {
    if (input.files && input.files[0]) {
        var filerdr = new FileReader();
        filerdr.onload = function (e) {
            $('#Images_img').attr('src', e.target.result);
        }
        filerdr.readAsDataURL(input.files[0]);
    }
}

function clear() {

    $("#IdPuzzle").val('');
    $("#Images").attr('src', "");
    $("#IdLevel").val('');
    $("#RowColumn").val('');
    $("#AnswerSequence").val('');
    $("#Coins").val('');
    $("#IsActive").val('');
}
function Close() {
    $('#popupmodal').modal('hide');
    window.location.href = $('head base').attr('href') + "Game1PuzzleImg/Index";
}

