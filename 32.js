//event listener for when button is pressed
var button = document.getElementById("btn1");
button.addEventListener('click', sliced, false);
//alert("Hello");

//retrieves the animal entered by user
function sliced() {
    var inputtext = document.getElementById("userinput1").value;
    document.getElementById("sliced1").innerHTML = inputtext.slice(4,5);
    document.getElementById("sliced2").innerHTML = inputtext.slice(4,8);
}

