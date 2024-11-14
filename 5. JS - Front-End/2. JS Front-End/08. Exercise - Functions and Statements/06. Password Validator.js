function validatePassword(password){
    let isValid = true;
    const specialCharPattern = /^[a-zA-Z0-9]+$/g;
    const digitsPattern = /\d/g;

    if(!(password.length >= 6 && password.length <= 10)){
        console.log("Password must be between 6 and 10 characters");
        isValid = false;
    }
    if(!password.match(specialCharPattern)){
        console.log("Password must consist only of letters and digits");
        isValid = false;
    }
    if(!((password.match(digitsPattern) || []).length >= 2)){
        console.log("Password must have at least 2 digits");
        isValid = false;
    }
    if(isValid){
        console.log("Password is valid");
    }
}

validatePassword('12');
