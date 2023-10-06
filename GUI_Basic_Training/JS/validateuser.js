/*
checks if a username cookie is set or not
if yes it returns the cookie else false */
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


