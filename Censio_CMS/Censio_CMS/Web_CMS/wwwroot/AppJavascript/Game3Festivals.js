function Close() {
    $('#popupmodal').modal('hide');
    window.location.href = $('head base').attr('href') + "Game3Festivals/Index";
}

function AddEdit() {

    var formData = new FormData();
    formData.append("IdFestivalLog", $("#IdFestivalLog").val());
    formData.append("IdFestival", $("#IdFestival").val());
    formData.append("FestivalSequence", $("#FestivalSequence").val());
    formData.append("FestivalName", $("#FestivalName").val());
    formData.append("FestivalImagepath", $("#FestivalImagepath").val());
    formData.append("RawMaterial", $("#RawMaterial").val());
    formData.append("RawMaterialExactqty", $("#RawMaterialExactqty").val());
    formData.append("RawMaterialMinQtyPast", $("#RawMaterialMinQtyPast").val());
    formData.append("RawMaterialMinQtyFuture", $("#RawMaterialMinQtyFuture").val());
    formData.append("ScoreAbsoluteCalculated", $("#ScoreAbsoluteCalculated").val());
    formData.append("PrimaryMaterialScore", $("#PrimaryMaterialScore").val());
    formData.append("SecondaryMaterialScorePositive", $("#SecondaryMaterialScorePositive").val());
    formData.append("SecondaryMaterialScoreNegative", $("#SecondaryMaterialScoreNegative").val());
    formData.append("RawMaterialImagepath", $("#RawMaterialImagepath").val());
    formData.append("MessageMaxQtySuccess", $("#MessageMaxQtySuccess").val());
    formData.append("MessageMaxQtyFail", $("#MessageMaxQtyFail").val());
    formData.append("MessageMinQtySuccess", $("#MessageMinQtySuccess").val());
    formData.append("MessageMinQtyFail", $("#MessageMinQtyFail").val());
    formData.append("MessageFestivalSuccess", $("#MessageFestivalSuccess").val());
    formData.append("MessageFestivalFail", $("#MessageFestivalFail").val());
    formData.append("TimeRequiredSeconds", $("#TimeRequiredSeconds").val());
    formData.append("CreatedBy", $("#CreatedBy").val());
    formData.append("Status", $("#Status").val());




    //var ObjectLists = [];
    //$("#idbehavior option:selected").each(function () {

    //    var Value = $(this).val();
    //    Idbehavior = [

    //        Value,
    //    ]
    //    ObjectLists.push(Idbehavior);

    //});
    //formData.append("Game5Behaviors", ObjectLists.toString());

    $.ajax({
        type: 'POST',
        url: $('head base').attr('href') + 'Game3Festivals/AddEdit',
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
                        window.location.href = $('head base').attr('href') + "Game3Festivals/Index";
                    }
                    else {
                        window.location.href = $('head base').attr('href') + "Game3Festivals/Index";
                    }
                    $("#myAlert").html(myhtml);
                    $("#myAlert").fadeIn(500).delay(3000).fadeOut(1000);
                    $("#myAlert2").html(myhtml);
                    $("#myAlert2").fadeIn(500).delay(3000).fadeOut(1000);
                    $('.loader').hide();
                    $('#btn').prop("disabled", false);
                }
                else {
                    
                    myhtml = '<div  style=" text-align: center;" class="alert-danger"><strong></strong> ' + response.message + '</div>';
                    $("#myAlert").html(myhtml);
                    $("#myAlert").fadeIn(5000).delay(30000).fadeOut(10000);
                    $("#myAlert2").html(myhtml);
                    $("#myAlert2").fadeIn(5000).delay(30000).fadeOut(10000);
                    $('.loader').hide();
                    $('#btn').prop("disabled", false);
                }


            }
            else {
                alert("Error");
            }
        }
    });
}

function clear() {


    $("#FestivalSequence").val('');
    $("#FestivalName").val('');
    $("#FestivalImagepath").val('');
    $("#RawMaterial").val('');
    $("#RawMaterialExactqty").val('');
    $("#RawMaterialMinQtyPast").val('');
    $("#RawMaterialMinQtyFuture").val('');
    $("#ScoreAbsoluteCalculated").val('');
    $("#PrimaryMaterialScore").val('');
    $("#SecondaryMaterialScorePositive").val('');
    $("#SecondaryMaterialScoreNegative").val('');
    $("#RawMaterialImagepath").val('');
    $("#MessageMaxQtySuccess").val('');
    $("#MessageMaxQtyFail").val('');
    $("#MessageMaxQtyFail").val('');
    $("#MessageMinQtySuccess").val('');
    $("#MessageMinQtyFail").val('');
    $("#MessageFestivalFail").val('');
    $("#TimeRequiredSeconds").val('');
    $("#Status").val('');


}



