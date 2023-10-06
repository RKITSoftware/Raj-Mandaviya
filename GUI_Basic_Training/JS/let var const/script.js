//var

var a = "Var outside block"
console.log(a);
{
    var a = "var inside block"; //Changes global var
    console.log(a);
    
    console.log(hoistedA); //undefined -> hoisting declares variable at top but does not assign it
    hoistedA = 10
    console.log(hoistedA); //10
}
console.log(a);
var a = "outside 2"  //Can be redecalared
console.log(a);

a = "hello"; console.log(a); //Can be reassigned
var hoistedA = 10;

//let

let b = "let outside block"
{
    //does not Change global let -> block scoped
    let b = "let inside block"; 
    console.log(b);
    // console.log(hoistedB); //Error -> let variables are not hoisted
}
// let b = "outside 2" //error -> cannot re-declare
console.log(b);

b = "hello"; console.log(b); //Can be reassigned

let hoistedB = 10;

//const

const C = "const outside block"
{
    //does not Change global const -> block scoped
    const C = "const inside block"
    console.log(C);
    // console.log(hoistedC); //Error -> const variables are not hoisted
}
console.log(C);

// C = "hello" //Error cannot reasign a constant

const hoistedC = 10;


five = 5 //global variable 
{
    five = 6 //global variables can be reassigned
    console.log(five);
}
console.log(five);

// console.log(ten);//error -> not declared beacuse global variables are not hoisted
ten = 10