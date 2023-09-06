
function det(){
    var details={
        name:document.getElementById("name").value,
        email:document.getElementById("email").value,
        phoneno:document.getElementById("phoneno").value,
        gender:document.getElementById("gender").value,
        dob:document.getElementById("dob").value,
        door:document.getElementById("door").value,
        city:document.getElementById("city").value,
        state:document.getElementById("state").value,
        country:document.getElementById("country").value,
        pincode:document.getElementById("pincode").value,
        sport:document.getElementById("sport").value,

    }
    
    let empty = JSON.stringify(details);
    location.href = "outputs.html";
    document.getElementById("show").innerHTML = empty
    
    
    
}