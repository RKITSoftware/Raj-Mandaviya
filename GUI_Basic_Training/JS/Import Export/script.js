/*
Moduling is used when working in a collaborative env or a larger code base
IMP: 
Always add "type=module" in HTML file to consider script.js as a module
to use import export a file needs to be a module
*/
import {Add} from "./util.js";
import {Sub} from "./util.js";
import {Div} from "./util.js";
import {Division} from "./util.js";

import Usage from "./util.js"
import Use from "./util.js" //can use any name because only one function or property can be default

//imports every exported thing from util, giving alias here is compulsory
import * as util from "./util.js";  

// import {add, sub, div} from "./util.js"; This is a better approach

import {Add as Plus} from "./util.js"; //alias

console.log(Add(10,5));

console.log(Plus(10,10));

console.log(Sub(10,5));

console.log(Div(10,2));

console.log(Division(10,2));

console.log(100*util.PI);

console.log(Use());
console.log(Usage());


