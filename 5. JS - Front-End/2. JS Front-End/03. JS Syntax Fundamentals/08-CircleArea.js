function circleArea(num){
    if(typeof num !== 'number'){
        console.log(`We can not calculate the circle area, because we receive a ${typeof num}.`);
    }
    else{
        console.log(`${(num * num * Math.PI).toFixed(2)}`);
    }
}

circleArea(5);
circleArea('name');
circleArea(true);