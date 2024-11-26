function convertObject(json){
    const object = JSON.parse(json);
    const objectEntries = Object.entries(object);
    for(const[key, value] of objectEntries){
        console.log(`${key}: ${value}`)
    }
}

convertObject('{"name": "George", "age": 40, "town": "Sofia"}');