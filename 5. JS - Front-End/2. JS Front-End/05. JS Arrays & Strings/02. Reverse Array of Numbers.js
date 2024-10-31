function reversedArray(count, array){
    let newArray = [];
    for (let i = 0; i < count; i++){
        newArray.push(array[i]);
    }

    console.log(newArray.reverse().join(' '));
}

reversedArray(3, [10, 20, 30, 40, 50]);