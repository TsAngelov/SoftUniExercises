function leapYearCheck(year){
    if( year % 4 == 0 && year % 100 != 0){
        console.log('yes');
    }
    else if (year % 400 == 0){
        console.log('yes');
    }
    else{
        console.log('no');
    }
}

leapYearCheck(1984);
leapYearCheck(2003);
leapYearCheck(4);