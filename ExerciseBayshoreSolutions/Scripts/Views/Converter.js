$(function () {
	$("#btnFrm").click(function () {
		SendRequest();
	});

	$('#inpNumber').keypress(function (e) {
		if (e.keyCode === 13) {
			e.preventDefault();
			SendRequest();
		}
	});
	return false;
});

function SendRequest() {
	var reqUrl = $(".divData").data("url");
	var datReq = $("#frmConv").serialize();
	$.ajax({
		url: reqUrl,
		type: 'post',
		data: datReq,
		success: function (result) {
			$(".divData").html('<label>Number entered: </label><p>' + result.res + '</p>');
		},
		error: function () {
			console.log("An error occurred on the request");;
		}
	});
}