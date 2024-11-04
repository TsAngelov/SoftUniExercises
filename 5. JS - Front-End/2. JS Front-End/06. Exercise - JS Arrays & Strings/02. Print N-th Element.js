function printNthNumber(array, number){
    let arrayNew = [];

    for(let i = 0; i < array.length; i+= number){
        arrayNew.push(array[i]);
    }

    return arrayNew;
}

printNthNumber(['5', '20', '31', '4', '20'], 2);