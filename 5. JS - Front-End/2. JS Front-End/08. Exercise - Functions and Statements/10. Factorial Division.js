function factorialDivision(numOne, numTwo){
    function calculateFactorial(number){
        if(number == 1 || number == 0){
            return 1;
        }
        else{
            return number * calculateFactorial(number - 1);
        }
    }

    let firstFactorial = calculateFactorial(numOne);
    let secondFactorial = calculateFactorial(numTwo);

    console.log((firstFactorial/secondFactorial).toFixed(2));
}

factorialDivision(5, 2);
factorialDivision(6, 2);