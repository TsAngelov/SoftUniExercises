function cookNumbers(number, op1, op2, op3, op4, op5){
    number = Number(number);

    function doOperation(op, number){
        if(op == 'chop')
            number/= 2;
        else if(op == 'dice')
            number = Math.sqrt(number);
        else if(op == 'spice')
            number+= 1;
        else if(op == 'bake')
            number *= 3;
        else
            number *= 0.8;

        return number;
    }

    console.log(number = doOperation(op1, number));
    console.log(number = doOperation(op2, number));
    console.log(number = doOperation(op3, number));
    console.log(number = doOperation(op4, number));
    console.log(number = doOperation(op5, number));
}

cookNumbers('32', 'chop', 'chop', 'chop', 'chop', 'chop');
cookNumbers('9', 'dice', 'spice', 'chop', 'bake', 'fillet');