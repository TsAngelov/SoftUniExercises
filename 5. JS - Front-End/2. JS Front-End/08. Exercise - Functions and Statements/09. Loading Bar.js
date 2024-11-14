function loadingBar(percentage){
    let percent = `[${('%'.repeat(percentage/10)).padEnd(10,'.')}]`;
    if(percentage != 100){
        console.log(`${percentage}% ${percent}`);
        console.log('Still loading...');
    }
    else{
        console.log('100% Complete!');
        console.log(percent);
    }
}

loadingBar(100);