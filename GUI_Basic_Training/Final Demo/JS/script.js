
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
    This function will take password element as input and 
    toggles Password visibility from text to password and vice versa
    */
    PasswordVisibilityToggle(password){
        password.type = password.type === "password" ? "text" : "password";
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
    btnShowPassword.addEventListener("click", function () {
        formValidator.PasswordVisibilityToggle(password) 
    });

}