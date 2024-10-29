function sumDigits(num){
    let sum = 0;
    let number = num;
    while (number > 0){
        sum += number % 10;
        number = Math.floor(number/10);
    }
    
    console.log(sum);
}

sumDigits(245678);
sumDigits(97561);
sumDigits(543);