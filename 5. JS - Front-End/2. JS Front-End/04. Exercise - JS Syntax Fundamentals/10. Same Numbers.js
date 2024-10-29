function sameNumbers(number){
    let stringNumber = String(number);
    let sum = Number(stringNumber[0]);
    let isSame = true;

    for(let i = 1; i < stringNumber.length; i++){
        sum += Number(stringNumber[i]);

        if(!(stringNumber[i] == stringNumber[i-1]))
        {
            isSame = false;
        }
    }

    console.log(isSame);
    console.log(sum);
}

sameNumbers(1234);