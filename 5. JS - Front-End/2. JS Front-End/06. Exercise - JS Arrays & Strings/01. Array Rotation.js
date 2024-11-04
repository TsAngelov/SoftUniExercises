function rotateArray(array, nRotations){
    for(let i = 0; i < nRotations; i++){
        array.push(array.shift(0));
    }

    console.log(array.join(' '));
}

rotateArray([51, 47, 32, 61, 21], 2);
