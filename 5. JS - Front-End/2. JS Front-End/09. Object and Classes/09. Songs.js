function songSort(input){
    class Song {
        constructor(typeList, name, time){
            this.typeList = typeList,
            this.name = name,
            this.time = time
        }
    }

    let songs = [];

    const songCount = input[0];
    const listType = input[input.length-1];

    for(let i = 1; i <= songCount; i++){
        const [typeList, name, time] = input[i].split('_');
        songs.push(new Song(typeList, name, time));
    }

    if(listType == 'all'){
        songs.forEach(song => {
            console.log(song.name);
        });
    }
    else{
        songs.filter((song) => song.typeList == listType).forEach(song => {
            console.log(song.name);
        });
    }
}

songSort([3, 'favourite_DownTown_3:14', 'favourite_Kiss_4:16', 'favourite_Smooth Criminal_4:01', 'favourite']);