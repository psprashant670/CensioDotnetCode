function AddEdit() {

    var formData = new FormData();
    formData.append('ChallengeSmallImgUrlfile', $('#ChallengeSmallImgUrlfile')[0].files[0]);
    formData.append('ChallengeBigImgUrlfile', $('#ChallengeBigImgUrlfile')[0].files[0]);
    formData.append('ChallengePieceMapImgUrlfile', $('#ChallengePieceMapImgUrlfile')[0].files[0]);
    formData.append("ChallengeSmallImgUrl", $("#ChallengeSmallImgUrl").val());
    formData.append("ChallengeBigImgUrl", $("#ChallengeBigImgUrl").val());
    formData.append("ChallengePieceMapImgUrl", $("#ChallengePieceMapImgUrl").val());
    formData.append("IdLevel", $("#IdLevel").val());
    formData.append("IdGame", $("#IdGame").val());
    formData.append("ChallengeName", $("#ChallengeName").val());
    formData.append("ChallengeSmallImgUrl", $("#ChallengeSmallImgUrl").val());
    formData.append("IdOrganization", $("#IdOrganization").val());
    formData.append("ChallengeBigImgUrl", $("#ChallengeBigImgUrl").val());
    formData.append("IsActive", $("#IsActive").val());
    formData.append("BigImgText", $("#BigImgText").val());
    formData.append("ChallengeIntroMessage", $("#ChallengeIntroMessage").val());
    formData.append("BottomCompleteMessage", $("#BottomCompleteMessage").val());
    formData.append("BottomFailMessage", $("#BottomFailMessage").val());
    formData.append("ChallengePieceMapImgUrl", $("#ChallengePieceMapImgUrl").val());
    formData.append("ChallengePieceMapMsg", $("#ChallengePieceMapMsg").val());
    formData.append("AgainPlayCoins", $("#AgainPlayCoins").val());
    formData.append("AttemptsAllowed", $("#AttemptsAllowed").val());
    formData.append("AttemptTimer", $("#AttemptTimer").val());
  
    formData.append("ThirdGameScore", $("#ThirdGameScore").val());
    formData.append("SpecialPoint", $("#SpecialPoint").val());
    formData.append("NotBackingOutMsg", $("#NotBackingOutMsg").val());
    formData.append("SuperpowerCoinGame3", $("#SuperpowerCoinGame3").val());
    $.ajax({

        type: 'POST',
        url: $('head base').attr('href') + 'GameChallengelevel/AddEdit',
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
                        window.location.href = $('head base').attr('href') + "GameChallengelevel/Create";
                    }
                    else {
                        window.location.href = $('head base').attr('href') + "GameChallengelevel/Index";
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
function ChallengeSmallImgUrlshow(input) {
    if (input.files && input.files[0]) {
        var filerdr = new FileReader();
        filerdr.onload = function (e) {
            $('#ChallengeSmallImgUrl_img').attr('src', e.target.result);
        }
        filerdr.readAsDataURL(input.files[0]);
    }
}
function ChallengeBigImgUrlshow(input) {
    if (input.files && input.files[0]) {
        var filerdr = new FileReader();
        filerdr.onload = function (e) {
            $('#ChallengeBigImgUrl_img').attr('src', e.target.result);
        }
        filerdr.readAsDataURL(input.files[0]);
    }
}
function ChallengePieceMapImgUrlshow(input) {
    if (input.files && input.files[0]) {
        var filerdr = new FileReader();
        filerdr.onload = function (e) {
            $('#ChallengePieceMapImgUrl_img').attr('src', e.target.result);
        }
        filerdr.readAsDataURL(input.files[0]);
    }
}
function clear() {

    $("#IdLevel").val('');
    $("#ChallengeSmallImgUrl").attr('src', "");
    $("#ChallengeBigImgUrl").attr('src', "");
    $("#ChallengePieceMapImgUrl").attr('src', "");
    $("#IdGame").val('');
    $("#ChallengeName").val('');
    $("#ChallengeSmallImgUrl").val('');
    $("#IdOrganization").val('');
    $("#ChallengeBigImgUrl").val('');
    $("#IsActive").val('');
    $("#BigImgText").val('');
    $("#ChallengeIntroMessage").val('');
    $("#BottomCompleteMessage").val('');
    $("#BottomFailMessage").val('');
    $("#ChallengePieceMapImgUrl").val('');
    $("#ChallengePieceMapMsg").val('');
    $("#AgainPlayCoins").val('');
    $("#AttemptsAllowed").val('');
    $("#AttemptTimer").val('');
   
    $("#ThirdGameScore").val('');
    $("#SpecialPoint").val('');
    $("#NotBackingOutMsg").val('');
    $("#SuperpowerCoinGame3").val('');
}
function Close() {
    $('#popupmodal').modal('hide');
    window.location.href = $('head base').attr('href') + "GameChallengelevel/Index";
}

function Gamechange() {
    debugger;
    if ($("#IdGame").val() == "3") {
        $("#Game3").css("display", "block");
    }

    else {
        $("#Game3").css("display", "none");
    }

}