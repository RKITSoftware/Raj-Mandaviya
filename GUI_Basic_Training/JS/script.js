
class FormValidator{
    
    constructor(){
        this.formError = true;
        this.Theme();
    }
    /*
    This method will be called by default 
    if()
    */
    Theme() {
        //Setting theme in all pages
        let theme = localStorage.getItem("theme");
        console.log(theme);
        if(theme){
            document.body.className = theme === "dark" ? "bg-dark text-light" : "bg-light text-dark";
        }
        else{
            document.body.className = "bg-light text-dark"
        }
    }

    // A Static method which can be called based on requirement of generating a random password 
    static GenerateRandomPassword() {
        const charset = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        let password = "";
        for (let i = 0; i < 8; i++) {
            const randomIndex = Math.floor(Math.random() * charset.length);
            password += charset[randomIndex];
        }
        return password;
    }

    /*
    This function will take a password and a messagelabel element as parameters.
    Checks if password length is smaller than 8 and manipulates message labels 
    */
    ValidatePasswordLength(password,passwordValidationMsg){
                if(password.value.length < 8){
                    passwordValidationMsg.innerText = "Password must be longer that 8 characters";
                    passwordValidationMsg.className = "text-danger";
                    this.formError = true;
                }
                else{
                    passwordValidationMsg.innerText = "OK!";
                    passwordValidationMsg.className = "text-success";
                    this.formError = false;
                    
                }    
    }
    /*
    This function will take password, cPassword, and a messagelabel element as parameters.
    Checks if password and confirmpassowrd are same or not and manipulates message labels 
    */
    MatchPasswords(password,cPassword,passwordValidationMsg) {
                if(password.value !== cPassword.value){
                    passwordValidationMsg.innerText = "Passwords do not match";
                    passwordValidationMsg.className = "text-danger";
                    this.formError = true;
                }
                else{
                    passwordValidationMsg.innerText = "OK!";
                    passwordValidationMsg.className = "text-success";
                    this.formError = false;
                }
            };
        
    /*
    This function will take password element as input and 
    toggles Password visibility from text to password and vice versa
    */
    PasswordVisibilityToggle(password){
        password.type = password.type === "password" ? "text" : "password";
    }

    IsEmptyValidator(event,name,email,password,cPassword,checkboxArray){
        if (name === "" || email === "" || password === "" || cPassword === "") {
            event.preventDefault();
            alert("All * fields are required");
        }
        else if(checkboxArray.length === 0){
                event.preventDefault();
                    alert("Select atleast one technology!");
        } 
        else if (this.formError) {
            event.preventDefault();
            alert("Please fill the form correctly!");
        }
    }
   
}




const formValidator = new FormValidator();

const password = document.getElementById("password");
const cPassword = document.getElementById("cPassword");
const passwordValidationMsg = document.getElementById("passwordValidationMsg");
const cPasswordValidationMsg = document.getElementById("cPasswordValidationMsg");

const btnShowPassword = document.getElementById("btnShowPassword");
const btnShowCPassword = document.getElementById("btnShowCPassword");

//Validating Password. Will validate only if Password element exists
if(password){
    // Wont work as there should be a callback function with an event
    // password.addEventListener("blur", formValidator.ValidatePasswordLength(password,passwordValidationMsg)); 
    password.addEventListener("blur", function() {
        formValidator.ValidatePasswordLength(password,passwordValidationMsg)
    })

    btnShowPassword.addEventListener("click", function () {
        formValidator.PasswordVisibilityToggle(password) 
    });

}
//Validating Confirm Password. Will validate only if cPassword element exists
if(cPassword){
    cPassword.addEventListener("blur", function () {
        formValidator.ValidatePasswordLength(cPassword,cPasswordValidationMsg)
    });
    cPassword.addEventListener("blur",function(){
        formValidator.MatchPasswords(password,cPassword,cPasswordValidationMsg)
    });

    btnShowCPassword.addEventListener("click", function () {
        formValidator.PasswordVisibilityToggle(cPassword) 
    });
}

//Validating if any field required is empty or not
const regForm = document.getElementById("regForm");
if (regForm) {
    regForm.addEventListener("submit", function (event) {
        event.preventDefault();
        
        const name = event.target.name.value
        const email = event.target.email.value;
        const technologies = document.querySelectorAll("input[name=tech]:checked");
        
        formValidator.IsEmptyValidator(event,name,email,password.value,cPassword.value,technologies);
        
    });
    }



// if(a){ 
//     console.log("val of a",a);  //Will not execute if a is false or null or undefined 
// }
