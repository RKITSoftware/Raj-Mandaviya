// Password Validation

var password1 = document.getElementById("password1")
var password2 = document.getElementById("password2")
const PasswordValidationMsg1 = document.getElementById("PasswordValidationMsg1")
const PasswordValidationMsg2 = document.getElementById("PasswordValidationMsg2")

var form_error = true;

password1.addEventListener("blur", function(){
    if(password1.value.length < 8){
        PasswordValidationMsg1.innerText = "Password must be longer that 8 characters"
        PasswordValidationMsg1.className = "text-danger";
    }
    else{
        PasswordValidationMsg1.innerText = "OK!";
        PasswordValidationMsg1.className = "text-success";
        form_error = false;
        
    }
})

password2.addEventListener("blur", function (){
    console.log(password1.value, password2.value);
    if(password1.value !== password2.value){
        PasswordValidationMsg2.innerText = "Passwords do not match";
        PasswordValidationMsg2.className = "text-danger";
    }
    else if(password2.value.length < 8){
        PasswordValidationMsg2.innerText = "Password must be longer that 8 characters"
        PasswordValidationMsg2.className = "text-danger";
        
    }
    else{
        PasswordValidationMsg2.innerText = "OK!";
        PasswordValidationMsg2.className = "text-success";
        form_error = false;
    }
});


function Password1VisibilityToggle(){
    
    if(password1.type === "password"){
        password1.type = "text"
    }else{
        password1.type = "password"
    }
}
function Password2VisibilityToggle(){
    if(password2.type === "password"){
        password2.type = "text"
    }else{
        password2.type = "password"
    }
}

document.getElementById("RegForm").addEventListener("submit",function(event){

    
    var name = document.getElementById("name").value;
    var email = document.getElementById("email").value;
    var password = document.getElementById("password1").value;
    var password = document.getElementById("password2").value;

    console.log(form_error);
    
    if (name === "" || email === "" || password === "") {
        alert("All fields are required");
        event.preventDefault(); // Prevent form submission
    } 
    else if(form_error){
       preventDefault();
       console.log(form_error);
    }
   

});


