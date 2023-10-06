//Arrow Functions
const GreetRaj = () =>{  //Regular Arrow function
    console.log("Welcome Raj");
}

const GreetAum = () => console.log("Welcome Aum"); //Single Statements

const GreetJay = () => console.log("Welcome Jay"); console.log("Hello");  //Multiple Statements ';' separated "Not recommended"

const GreetSomeone = (name, greeting) => console.log(`${greeting} ${name}`); console.log("Hello"); //Parameterized

const GreetSomebody = name => console.log(`Welcome ${name}`); console.log("Hello");  //Works without paranthesis with single parameter

// const greetSomebody = name, greeting => console.log(`${greeting} ${name}`); console.log("Hello"); //error "Paranthesis compulsory"

//'this' will be window object when using JS Function inside a Function     
const studentA = {
    name : "Raj",
    age : 20,
    tech : "ASP",
    ShowDetails : function () {
        setTimeout(function(){
            console.log(this);
        }, 1000);
    }
}

//'this' inside an arrow function will be the object of parent scope.
const studentB = {
    name : "Raj",
    age : 20,
    tech : "ASP",
    ShowDetails : function () {
        setTimeout(()=>{
            console.log(this);
        }, 1000);
    }
}


studentA.ShowDetails();
studentB.ShowDetails();




GreetRaj();
GreetAum();
GreetJay();
GreetSomeone("Dev", "Good Morning");
GreetSomebody("Dev");
