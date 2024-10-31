function evenOddSubtraction(array){
    let evenSum = 0;
    let oddSum = 0;

    for (const number of array) {
        if(number % 2 == 0)
            evenSum += number;
        else
            oddSum += number;
    }

    console.log(evenSum-oddSum);
}

evenOddSubtraction([2,4,6,8,10]);
evenOddSubtraction([3,5,7,9]);