let i=1;
let win = false;
let position = true;
list = ["1","2","3","4","5","6","7","8","9"];
function display(value,id_name){
    let winner = "";
    let element = document.getElementById(id_name);
    if(i<=9 && win==false && position==true){
        if(i%2==1){
            document.getElementById("display").innerHTML = "Enter position of \'X\'";
            element.style.backgroundImage = "url(https://static.vecteezy.com/system/resources/thumbnails/017/178/409/small/red-cross-check-mark-on-transparent-background-free-png.png)";
            element.style.backgroundSize = "2.8cm";
            element.style.backgroundRepeat = "no-repeat";
            element.setAttribute = "Disabled"
            if(list[value-1]=="X" || list[value-1]=="O"){
                document.getElementById("display").innerHTML = "Wrong position...Restart the game";
                position = false;
            }
            else{
                list[value-1] = "X";
                check();
                if(win==true){
                    document.getElementById("display").innerHTML = "Player \'X\' Wins.....";
                }
                else if(win==false && i==9){
                    document.getElementById("display").innerHTML = "Game tie.........";
                }
            }
        }
        else{
            document.getElementById("display").innerHTML = "Enter position of \'O\'";
            element.style.backgroundImage = "url(https://www.nicepng.com/png/full/371-3713738_select-the-sign-transparent-letter-o-circle.png)";
            element.style.backgroundSize = "2.5cm";
            element.style.backgroundRepeat = "no-repeat";
            if(list[value-1]=="X" || list[value-1]=="O"){
                document.getElementById("display").innerHTML = "Wrong position...Restart the game";
                position = false;
            }
            else{
                list[value-1] = "O";
                check();
                if(win==true){
                    document.getElementById("display").innerHTML = "Player \'O\' Wins.....";
                }
                else if(win==false && i==9){
                    document.getElementById("display").innerHTML = "Game tie.........";
                }
            }
        }
    }
    else{
        document.getElementById("display").innerHTML = "Restart the game............";
    }
    i++;
    
}
function check(){
    if(list[0]==list[1] && list[0]==list[2]){
        win = true;
    }
    else if(list[3]==list[4] && list[3]==list[5]){
        win = true;
    }
    else if(list[6]==list[7] && list[6]==list[8]){
        win = true;
    }
    else if(list[0]==list[3] && list[0]==list[6]){
        win = true;
    }
    else if(list[1]==list[4] && list[1]==list[7]){
        win = true;
    }
    else if(list[2]==list[5] && list[2]==list[8]){
        win = true;
    }
    else if(list[0]==list[4] && list[0]==list[8]){
        win = true;
    }
    else if(list[2]==list[4] && list[2]==list[6]){
        win = true;
    }
}