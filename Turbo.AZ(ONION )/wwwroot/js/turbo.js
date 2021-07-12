$(function () {
    $("#brandList").change(function () {
        $.getJSON("/Home/GetModels", { brandId: $("#brandList").val() }, function (d) {
            var row = "";
            console.log(d);
            $("#modelList").empty();
            row += "<option>" + "Seçin" + "</option>"
            $.each(d, function (i, v) {
                row += "<option value=" + v.modelId + ">" + v.modelName + "</option>"
            });
            $("#modelList").html(row);
        })
    })
})

$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Home/GetBrands",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Seçin</option>';
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].brandId + '">' + data[i].brandName + '</option>';
            }
            $("#brandList").html(s);
        }
    });
});

$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Home/GetFuel",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Seçin</option>';
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].fuelId + '">' + data[i].fuelName + '</option>';
            }
            $("#FuelId").html(s);
        }
    });
});
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Home/GetColors",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Seçin</option>';
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].colorId + '">' + data[i].colorName + '</option>';
            }
            $("#ColorId").html(s);
        }
    });
});
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Home/GetBodies",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Seçin</option>';
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].bodyId + '">' + data[i].bodyName + '</option>';
            }
            $("#BodyId").html(s);
        }
    });
});
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Home/GetGearBoxes",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Seçin</option>';
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].gearBoxId + '">' + data[i].gearBoxName + '</option>';
            }
            $("#GearBoxId").html(s);
        }
    });
});
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Home/GetEngineVolumes",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Seçin</option>';
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].engineVolumeId + '">' + data[i].engineVolumeName + '</option>';
            }
            $("#EngineVolumeId").html(s);
        }
    });
});
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Home/GetTransmissions",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Seçin</option>';
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].transmissionId + '">' + data[i].transmissionName + '</option>';
            }
            $("#TransmissionId").html(s);
        }
    });
});
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Home/GetCities",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Seçin</option>';
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].cityId + '">' + data[i].cityName + '</option>';
            }
            $("#CityId").html(s);
        }
    });
});
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Home/GetValutes",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Seçin</option>';
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].valuteId + '">' + data[i].valuteName + '</option>';
            }
            $("#ValuteId").html(s);
        }
    });
});
$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "/Home/GetYears",
        data: "{}",
        success: function (data) {
            var s = '<option value="-1">Seçin</option>';
            console.log("Year catdim");
            console.log(data);
            for (var i = 0; i < data.length; i++) {
                s += '<option value="' + data[i].yearId + '">' + data[i].yearName + '</option>';
            }
            $("#yearList").html(s);
        }
    });
});