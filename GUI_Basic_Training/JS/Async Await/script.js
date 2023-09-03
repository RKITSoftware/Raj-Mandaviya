
/*Here we will wait for document list to arrive and then will wait for aadharcard pdf to arrive
Return both in the promise */

//async function always return a promise
async function FetchFromDigilocker() {
    let id = 15;
    //In Promise state is initially pending and then resolved or rejected
    let GetDocList = new Promise((resolve, reject) => {  
        setTimeout(() => {
            if(id===15){
                resolve("Doclist is here")
            }else{
                reject(new Error("No Digilocker account found1"))
            }
        }, 3000)
    })

    let GetAadhar = new Promise((resolve, reject) => {
        setTimeout(() => {
            if(id===16){
                resolve("Aadhar is here")  //resolve can take any value (bool, int, array, string, etc.)
            }else{
                reject(new Error("No Digilocker account found2")); //promise throws a normal error 
            }
        }, 5000)
    })

    /*This will log values once the promise is executed.
     Function will wait for a promise to resolve and then next will be executed.
    */
    console.log("Fetching doclist");
    //await stops execution of the async function until a promise resolves or rejects
    let docList, aadhar;
    try{
        docList = await GetDocList;
        console.log(docList);
        console.log("Fetching Aadhar");
        aadhar  = await GetAadhar;
        console.log(aadhar);
    }
    catch(error){
        console.log(error); //handling error thrown by promise
    }

    return [docList, aadhar];
}


console.log("Starting Digilocker Services..")

//This will log values after execution of both promises
let data = FetchFromDigilocker()
console.log(data);  

data.then((value)=>{
    console.log(value);
}).catch((error)=>{ 
    console.log("An Error occured: ",error);
})

// console.log(a);
