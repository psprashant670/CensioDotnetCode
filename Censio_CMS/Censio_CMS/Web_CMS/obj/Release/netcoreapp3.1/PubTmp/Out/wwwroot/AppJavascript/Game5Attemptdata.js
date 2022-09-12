function AddEdit() {

    var formData = new FormData();

    formData.append("IdAttempt", $("#IdAttempt").val());
    formData.append("IdLevel", $("#IdLevel").val());
    formData.append("AttemptNo", $("#AttemptNo").val());
    formData.append("IdGame", $("#IdGame").val());
    formData.append("GoldCoins", $("#GoldCoins").val());
    formData.append("BehaviorScore", $("#BehaviorScore").val());
    formData.append("TimeInSecond", $("#TimeInSecond").val());
    formData.append("ChallengeCompletedTime1", $("#ChallengeCompletedTime1").val());
    formData.append("RewardCoinsTime1", $("#RewardCoinsTime1").val());
    formData.append("ChallengeCompletedTime2", $("#ChallengeCompletedTime2").val());
    formData.append("RewardCoinsTime2", $("#RewardCoinsTime2").val());
    formData.append("FailAttemptMessage", $("#FailAttemptMessage").val());
    formData.append("SuccessAttemptMessage", $("#SuccessAttemptMessage").val());
    formData.append("IsActive", $("#IsActive").val());



    var ObjectLists = [];
    $("#idbehavior option:selected").each(function () {

        var Value = $(this).val();
        Idbehavior = [

            Value,
        ]
        ObjectLists.push(Idbehavior);

    });
    formData.append("Game5Behaviors", ObjectLists.toString());

    $.ajax({
        type: 'POST',
        url: $('head base').attr('href') + 'Game5Attemptdata/AddEdit',
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
                        window.location.href = $('head base').attr('href') + "Game5Attemptdata/Create";
                    }
                    else {
                        window.location.href = $('head base').attr('href') + "Game5Attemptdata/Index";
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



function FillChallenge() {

    var Id_Game = $('#IdGame').val();
    $.ajax({
        url: $('head base').attr('href') + 'Game5Attemptdata/FillChallenge',
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


    $("#IdAttempt").val('');
    $("#IdLevel").val('');
    $("#AttemptNo").val('');
    $("#IdGame").val('');
    $("#GoldCoins").val('');
    $("#BehaviorScore").val('');
    $("#TimeInSecond").val('');
    $("#ChallengeCompletedTime1").val('');
    $("#RewardCoinsTime1").val('');
    $("#ChallengeCompletedTime2").val('');
    $("#RewardCoinsTime2").val('');
    $("#FailAttemptMessage").val('');
    $("#SuccessAttemptMessage").val('');
    $("#IsActive").val('');


}
function Close() {
    $('#popupmodal').modal('hide');
    window.location.href = $('head base').attr('href') + "Game5Attemptdata/Index";
}