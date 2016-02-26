//event listener for when button is pressed
var button = document.getElementById("btn1");
button.addEventListener('click', texttypes, false);
//alert("Hello");

//retrieves the animal entered by user
function texttypes() {
    var inputtext = document.getElementById("userinput1").value;
    document.getElementById("unmodified").innerHTML = inputtext;
    document.getElementById("upcase").innerHTML = inputtext.toUpperCase();
    document.getElementById("lowcase").innerHTML = inputtext.toLowerCase();
}

