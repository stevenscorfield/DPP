//event listener for when button is pressed for sentence entry
var button = document.getElementById("btn1");
button.addEventListener('click', display, false);

//event listener for when button is pressed for entry search
var button = document.getElementById("btn2");
button.addEventListener('click', usersearch, false);
//alert("Hello");

//retrieves the user's sentence and displays it
function display() {
    var inputtext = document.getElementById("userinput1").value;
    document.getElementById("sentence").innerHTML = inputtext;
}

//searches the user's sentence for a defined word and shows it's index
function usersearch() {
    var inputtext = document.getElementById("userinput1").value;
     alert(inputtext);
//find's the search keyword
    var string = document.getElementById("userinput2").value;
//searches for keyword and displays the index
    var position = inputtext.lastIndexOf(string);
   
    document.getElementById("search").innerHTML = position;
}
    //document.getElementById("sliced2").innerHTML = inputtext.slice(4,8);

