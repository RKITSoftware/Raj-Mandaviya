function DigilockerClass(name, aadhaar, age){ //Possible way to create a class in js
    this.name = name
    this.aadhaar = aadhaar
    this.age = age
    let daysInAMonth = 30

    this.GetProfile = function(){
        console.log(`Hello ${this.name}, Your aadhaar is ${aadhaar}`);
        console.log(`Your age in days is ${ageInDays()}`);
    }
    let ageInDays = () => {
        return daysInAMonth * 12 * age;
    }
    
}

let raj = new DigilockerClass("raj", '123456789',20)
raj.GetProfile();
// raj.ageInDays(); // error -> private function
// console.log(raj.daysInAMonth); //undefined -> private variable
