// check if user is loggedin or not
function IsLoggedIn() { 
    const cookies = document.cookie.split(';');
    for (let i = 0; i < cookies.length; i++) {
        const cookie = cookies[i].trim();
        if (cookie.startsWith(`username=`)) {
            return cookie;
        }
    }
    return false;
}  


