function radar(speed, area){
    let allowedSpeed;
    let speedingType;
    switch (area){
        case 'motorway': allowedSpeed = 130; break;
        case 'interstate': allowedSpeed = 90; break;
        case 'city': allowedSpeed = 50; break;
        case 'residential': allowedSpeed = 20; break;
    }

    if(speed > allowedSpeed){

        if(speed - allowedSpeed <= 20)
            speedingType = 'speeding';
        else if(speed - allowedSpeed <= 40)
            speedingType = 'excessive speeding';
        else
            speedingType = 'reckless driving';
        console.log(`The speed is ${speed - allowedSpeed} km/h faster than the allowed speed of ${allowedSpeed} - ${speedingType}`);
    }
    else
        console.log(`Driving ${speed} km/h in a ${allowedSpeed} zone`);
}

radar(40, 'city');
radar(120, 'interstate');