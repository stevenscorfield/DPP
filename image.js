function rectangle () {
    var c = document.getElementById("myCanvas");
    var ctx = c.getContext("2d");
    ctx.fillStyle = "#FF0000";
    ctx.fillRect(0,0,150,75);
}

function line (){
    var c = document.getElementById("myCanvas1");
    var ctx = c.getContext("2d");
    ctx.moveTo(0,0);
    ctx.lineTo(200,100);
    ctx.stroke();
}

function circle () {
    var c = document.getElementById("myCanvas2");
    var ctx = c.getContext("2d");
    ctx.beginPath();
    ctx.arc(95,50,40,0,2*Math.PI);
    ctx.fill();
    ctx.fillStyle = "#FF0000";
}

rectangle();
line();
circle();