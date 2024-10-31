function censorWords(text, censor){
    let textToCensor = text.replaceAll(censor, '*'.repeat(censor.length));

    console.log(textToCensor);
}

censorWords('A small sentence with some words', 'small');