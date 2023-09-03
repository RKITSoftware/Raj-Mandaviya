// Object Oriented JavaScript

//Prototypes
//Base Obj
let pObj = {
    name : "Drizzle",
    role : "Base Object"
}

console.log(pObj);
console.log(pObj.toString()) //Default prototype methods

newProto = {
    whoAmI : ()=>{
        console.log("I am first proto");
    }
}

pObj.__proto__ = newProto;
console.log(pObj.name);
pObj.whoAmI();

//Prototype chaining
latestProto = {
    authCheck : () =>{
        console.log("Yes you are authorized");
    }
}

newProto.__proto__  = latestProto;

pObj.authCheck();
