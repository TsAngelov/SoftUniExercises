function sortNumbers(array){
    array.sort((a,b) => a - b);

    let sortedArray = [];
    const arrayLength = array.length;

    for(let i = 0; i < arrayLength; i++){
        if(i % 2 == 0){
            sortedArray.push(array.shift());
        }
        else{
            sortedArray.push(array.pop());
        }
    }
    return sortedArray;
}

sortNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);