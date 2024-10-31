function countStringOccurence(text, wordtoSearch){
    let words = text.split(' ');
    let wordCounter = 0;

    for (const word of words) {
        if(word == wordtoSearch)
            wordCounter++;
    }

    console.log(wordCounter);
}

countStringOccurence('This is a word and it also is a sentence', 'is');