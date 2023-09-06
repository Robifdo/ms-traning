let num = Math.floor((Math.random()*100)+1)
let attempt = 0;
function guess(){
    if(document.getElementById("display").value>num){
        document.getElementById("hint").innerHTML="Guess lower";
        
    }
    else if(document.getElementById("display").value==num){
        document.getElementById("hint").innerHTML=" congrats!! Number found.. "+attempt+" attempts";
        document.getElementById("display").disabled = true;
    }
    else{
        document.getElementById("hint").innerHTML="Guess higher";
        
    }
    attempt++;
    document.getElementById("display").value = "";
    document.getElementById("display").focus();
}
function display(a){
    document.getElementById("display").value+=a;
}
