var data = 0;
var duplicate_data;
var arr = [1,2,3,4,5,6]
var row = "select the contact to make changes";
if(!localStorage.getItem("contactbook")){
    data = []
}
else{
    data = JSON.parse(localStorage.getItem("contactbook"))
}
window.onload = function(){
    // data.push(localStorage.getItem("contactbook"));
    document.getElementById("form").style.transform = "scale(1)";
}
function went(){
    window.location.href = "C:\Users\Administrator.MS-00601\Desktop\robi-git\ms-traning\contactbook\contactdetails.html"
}
function getdata(){


    
    let getdetails = {
    fname : document.getElementById("fname").value,
    lname : document.getElementById("lname").value,
    nname : document.getElementById("nname").value,
    mobnumber : document.getElementById("mobnumber").value,
    dob : document.getElementById("dob").value,
    email : document.getElementById("email").value,
    street : document.getElementById("street").value,
    place : document.getElementById("place").value,
    state : document.getElementById("state").value,
    country : document.getElementById("country").value,
    pincode : document.getElementById("pincode").value,
    work : document.getElementById("work").value,
    relation : document.getElementById("relation").value,
    notes : document.getElementById("notes").value,
    }
    let valid = false
    if(getdetails["fname"]){
        if(getdetails["mobnumber"]){
            if(getdetails["email"]){
                if(getdetails["state"]){
                    if(getdetails["place"]){
                        if(getdetails["pincode"]){
                            valid = true;
                        }
                    }
                }
            }
        }
    }
    if(valid===true){
            data.push(getdetails)
            localStorage.setItem("contactbook",JSON.stringify(data))
            alert("contact saved") 
            duplicate_data = data;
            // alert(JSON.stringify(duplicate_data))
        }
    else{
        alert("Enter the mandatory details !!!")
    }
    // duplicate_data = data
    // if(valid===true){
    //     window.location.href = "C:\Users\Administrator.MS-00601\Desktop\robi-git\ms-traning\contactbook\contactdetails.html";
    // }
}
// console.log(duplicate_data)
function details(){
// document.getElementById("total").style.transform = "scale(1)"

    let tabcon = document.createElement("div")
    document.body.appendChild(tabcon)
    tabcon.style.width = "45%"
    tabcon.style.margin = "0px 3%"
    tabcon.style.maxHeight = "70vh";
    tabcon.style.overflow = "scroll";
    tabcon.style.overflowX = "hidden";
    
    let detailsofcontact = JSON.parse(localStorage.getItem("contactbook"))
    let table = document.createElement("table")
    table.style.width = "100%";
    table.style.top = "0px"
    table.style.borderRadius = "20px"
    table.style.position = "relative"
    table.style.maxHeight = "70vh"
    tabcon.appendChild(table)
    for(let x of detailsofcontact){
        let tr = document.createElement("tr")
        tr.style.backgroundColor = "rgb(114, 164, 187)"
        tr.style.borderRadius = "20px"
        tr.style.fontSize = "30px";
        tr.style.textAlign = "center";
        tr.style.color = "aliceblue";
        tr.style.height = "2cm"
        tr.style.marginTop = "20px"
        table.appendChild(tr)
        let name = document.createElement("p")
        name.innerHTML =x["fname"];
        tr.appendChild(name)
        tr.addEventListener("click",function(){
            let rowi = tr.rowIndex;
            row = rowi
            localStorage.setItem("row",row)
            let p = document.getElementById("pop")
            document.getElementById("fn").innerHTML = ": "+detailsofcontact[rowi]["fname"]
            document.getElementById("ln").innerHTML = ": "+detailsofcontact[rowi]["lname"]
            document.getElementById("nn").innerHTML = ": "+detailsofcontact[rowi]["nname"]
            document.getElementById("mn").innerHTML = ": "+detailsofcontact[rowi]["mobnumber"]
            document.getElementById("em").innerHTML = ": "+detailsofcontact[rowi]["email"]
            document.getElementById("st").innerHTML = ": "+detailsofcontact[rowi]["street"]
            document.getElementById("pl").innerHTML = ": "+detailsofcontact[rowi]["place"]
            document.getElementById("sta").innerHTML = ": "+detailsofcontact[rowi]["state"]
            document.getElementById("con").innerHTML = ": "+detailsofcontact[rowi]["country"]
            document.getElementById("pin").innerHTML = ": "+detailsofcontact[rowi]["pincode"]
            document.getElementById("wor").innerHTML = ": "+detailsofcontact[rowi]["work"]
            document.getElementById("rel").innerHTML = ": "+detailsofcontact[rowi]["relation"]
            document.getElementById("not").innerHTML = ": "+detailsofcontact[rowi]["notes"]
        })
    }
    
}
function deletecontact(){
    let delcon = JSON.parse(localStorage.getItem("contactbook"))
    let empty = []
    console.log("row is "+row)
    if(confirm("Are you want to delete contact?")){
        for(let j=0;j<delcon.length;j++){
            if(j===row){
                continue;
            }
            else{
                empty.push(delcon[j])
            }
        }
        localStorage.setItem("contactbook",JSON.stringify(empty))
        document.location.reload();
    }
}
function editcontact(){
    if(row==="select the contact to make changes"){
        alert("select the contact to edit")
    }
    else{
        window.location.href = "editcontact.html"
        localStorage.setItem("row",row)
    }

    
}

function savecontact(){
        window.location.href = "savecontact.html"
}
