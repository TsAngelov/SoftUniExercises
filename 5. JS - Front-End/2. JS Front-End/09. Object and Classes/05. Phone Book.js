function processNumbers(input){
    const phoneBook = {};

    input.forEach(entry => {
        const splitEntry = entry.split(' ');
        const name = splitEntry[0];
        const number = splitEntry[1];

        phoneBook[name] = number;
    });

    for (key in phoneBook){
        console.log(`${key} -> ${phoneBook[key]}`);
    }
}

processNumbers(['Tim 0834212554', 'Peter 0877547887', 'Bill 0896543112', 'Tim 0876566344']);
