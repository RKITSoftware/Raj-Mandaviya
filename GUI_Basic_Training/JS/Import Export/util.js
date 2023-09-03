export function Add  (a,b) {
    return a + b;
}

export const Sub = (a,b) => {
    return a - b;
}

const Div = (a,b) => {
    return a/b;
}

/* 
const Usage = () => {
     return "Util module will be used to do mathematic operations"
} 

Export default wont work in the declaration line with arrow function
But it will work with normal Function

 export default Usage; 
 
*/

export default function Usage(){
    return "Util module will be used to do mathematic operation"
}
export const PI = 3.14;


//another way to export a function
export{
    Div,
    Div as Division  //Exporting with alias
} 
    