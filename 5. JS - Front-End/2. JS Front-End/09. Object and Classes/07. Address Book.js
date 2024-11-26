function arrangeMeetings(input){
    const addressBook = {};

    input.forEach(element => {
        const [name, address] = element.split(':');
        
        addressBook[name] = address;
    });

    const arrayAddress = Object.entries(addressBook).sort(([keyA, valueA] ,[keyB, valueB]) => {return keyA.localeCompare(keyB)});

    for (const [name, address] of arrayAddress) {
        console.log(`${name} -> ${address}`);
    }
}

arrangeMeetings(['Tim:Doe Crossing', 'Bill:Nelson Place', 'Peter:Carlyle Ave', 'Bill:Ornery Rd']);