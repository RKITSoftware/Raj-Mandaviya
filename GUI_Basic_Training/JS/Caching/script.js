// Caching
// let isCacheSupported = 'caches' in window; //TO check if caching is supported by the browser

const url = document.getElementById("miracleImg").src    

const urls = ['../../miracle-accounting-ssftware.png','../../reset.png'];

document.getElementById("btnAddMiracleCache").addEventListener("click", function(){
    //Creating a cache
    let cacheName = 'imageCache';
    caches.open(cacheName).then(cache => {
    });

    //Adding image to the cache    
    caches.open("imageCache").then(cache => {
        cache.add(url).then(cache => {
            console.log("img cached");
        });
    }); 
})

document.getElementById("btnAddAllCache").addEventListener("click", function(){
    //Creating a cache
    let cacheName = 'imageCache';
    caches.open(cacheName).then(cache => {
    });

    //Adding all images to the cache    
    caches.open("imageCache").then(cache => {
        cache.addAll(urls).then(() => {
            console.log("all imgs cached");
        });
    }); 
})


document.getElementById("btnDeleteCache").addEventListener("click", function(){
    //Deleting a cache
    caches.open("imageCache").then(cache => {
        cache.delete(url).then(() => {
            console.log("img deleted from cache");
        })
    })
    
    caches.delete("imageCache").then(() => {
        console.log('Cache deleted');
    });
})


