// Object Oriented JavaScript

//Encapsulation

class Digilocker{
    daysInAMonth = 30   //this variable can accessed using 'this' keyword
    #hoursInADay = 24   //Declaring Private variable
    constructor(name, aadhar, age){
        let daysInAYear = 365; //Declaring Private variable
        this.hours = this.daysInAMonth * this.#hoursInADay //accessing private variable
        this.ageInDays = age * daysInAYear; //accessing private variable
        this.name = name;
        this.aadhar = aadhar;
    }

    //Properties used to provide access of private variables "getters and setters"
    get HoursInADay() {
        return this.#hoursInADay
    }
    set HoursInADay(hrs){
        this.#hoursInADay = hrs
    }
    
    GetDocList(){
        console.log(`Hello ${this.name},You can fetch Issued or Uploaded documents from digilocker`);
    }
    
    GetAadhar(){
        console.log(`Hello ${this.name},Your Aadhar card is here with number ${this.aadhar}`);
        console.log(this.#GetSecretKey());
    }
    //Abstraction
    #GetSecretKey(){
        return 123;
    }
}


let raj = new Digilocker("Raj","123456789",20); //Undefined will be taken if any arg is not passed
console.log("Private variable", raj.daysInAYear); //Undefined because variables declared inside a constructor using let,var,const are private
console.log("Public Variable",raj.hours); //Variable attached with this keyword can be accessed using object of class
console.log("Public Variable", raj.daysInAMonth); //Variables declared outside constuctor 'without' # are public
console.log("Raj's age in days are "  + raj.ageInDays ); 
// console.log(raj.#hoursInADay); //Variables declared outside constuctor with # are private andccannot be accessed here

//Accessing Private variables using properties -> getter setter methods
raj.HoursInADay = 200
console.log(raj.HoursInADay);

raj.GetAadhar() //Acessing private function indirecly
// raj.#GetSecretKey() //error -> Private method





