(function () {
	var myNode = document.createElement('div');
	document.getElementById('digitalClock').appendChild(myNode);
	var checkForLeadingZeros = function (timeVal) {
		if (timeVal < 10) {
			timeVal = "0" + timeVal;
		}
		return timeVal;
	}


	var updateTime = function () {
		var myDate = new Date();
		myNode.innerHTML = myDate.toTimeString().substr(0, 8);
	}
	updateTime();
	setInterval(updateTime, 1000);

})();