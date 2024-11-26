// function cityLoop(array){
//     const keys = Object.keys(array);
//     keys.forEach(key => {
//         console.log(`${key} -> ${array[key]}`)
//     });
// }


function cityLoop(array){
    const entries = Object.entries(array);
    for (const[key, value] of entries){
        console.log(`${key} => ${value}`)
    }
}

cityLoop({
    name: "Sofia",
    area: 492,
    population: 1238438,
    country: 'Bulgaria',
    postCode: "1000" });