function buttonOnClick(event, arguments) {
	var myWindow = window,
		theBrowser = myWindow.navigator.appCodeName,
		ism = theBrowser == "Mozilla";

	if (ism) {
		alert("Yes");

	}
	else {
		alert("No");

	}

}