count = 0;
function check(email,password){
    pwd = "msindia@123";
    em = false;
    pd = false
    if(password===pwd){
        pd = true;
        for(i=0;i<email.length;i++){
            if(email[i]==="@"){
                let ename = email.slice(0,i);
                let domain = email.slice(i,email.length)
                if(domain==="@gmail.com"){
                    em = true;
                }
            }
        }
    }
    if(em===true && pd===true && count<=3){
        count=0;
        document.getElementById("demo").innerHTML="logging in.....";
        document.getElementById("demo").style.color="green";
    }
    else{
        document.getElementById("demo").innerHTML="Invalid mail id ";
        document.getElementById("demo").style.color="red"
    }
    count++;
    if(count>3){
        document.getElementById("demo").innerHTML="Try again later";
        document.getElementById("demo").style.color="red"
        window.alert("too many attempts refresh the page....")
    }
}