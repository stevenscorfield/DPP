//event listener for when button is pressed for sentence entry
var button = document.getElementById("btn1");
button.addEventListener('click', senloop, false);

//retrieves the user's sentence and displays it
function senloop() {
    var inputtext = document.getElementById("userinput1").value;
    var i;
    alert(i);
    for (i = 0; i < inputtext.length; i++) {
        docutment.getElementById("loop").innerHTML = inputtext;
    }
}

