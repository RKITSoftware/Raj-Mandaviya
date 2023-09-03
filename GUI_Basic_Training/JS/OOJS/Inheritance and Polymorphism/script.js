// Object Oriented JavaScript

//Class 
class Digilocker{
    //Called when an object is created
    constructor(name, aadhar){
        this.name = name;
        this.aadhar = aadhar;
        console.log("This is Digilocker constructor");
    }
   
    GetDocList(){
        console.log(`Hello ${this.name},You can fetch Issued or Uploaded documents from digilocker`);
    }

    GetAadhar(){
        console.log(`Hello ${this.name},Your Aadhar card is here with number ${this.aadhar}`);
    }
}

//Inherits all methods and properties of Digilocker
class IssuedDocuments extends Digilocker{
    /* If there is no Constructor in child class
    By default constructor of parent class will be called like bellow
    constructor(...args){
        super(...args)
    }*/
      
    constructor(name, aadhar){
        // console.log(this.name); gives error super() must be called before using this keyword
        super(name,aadhar);
        console.log("This is IssuedDocuments constructor");
    }

    //Method Overriding -> same name same parameters
    GetDocList(){
        console.log(`Hello ${this.name},Your Issued document list are here`);
    }
    
    GetAadhar(){
        super.GetAadhar();
        console.log("Aadhar will be used to fetch Issued Documents");
    }  

    GetMarksheet(){
        console.log("Marksheet is here");
    }
}

class UploadedDocuments extends Digilocker{

    constructor(name,aadhar,age){
        super(name,aadhar);
        this.age = age
    }

    //Method Overriding -> same name same parameters
    GetDocList(){
        console.log(`Hello ${this.name},Your Uploaded documents are here`);
    }

    GetAadhar(){
        super.GetAadhar();
        console.log(`Aadhar saying age of ${this.age} will be used to fetch Uploaded Documents`);
    }    
}


let raj = new Digilocker("Raj","123456789"); //Undefined will be taken if any arg is not passed
raj.GetDocList() //Method of parent class
raj.GetAadhar() //Method of parent class

let aum = new IssuedDocuments("Aum","784189149") //Here parent class constructor will be called first
aum.GetDocList() //Method of child class
aum.GetAadhar() //Method of child class

let jay = new UploadedDocuments("Jay","369852147")
jay.GetDocList() 
jay.GetAadhar()


// console.log(raj.age);  //variable of child class -> Undefined  
// console.log(raj.GetMarksheet()); //function of child class -> error

