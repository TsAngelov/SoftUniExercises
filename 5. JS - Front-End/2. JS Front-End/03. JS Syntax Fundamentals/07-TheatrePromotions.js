function theatrePromotion (day, age){
    switch(true){
        case (age >= 0 && age <= 18):
            switch(day){
                case 'Weekday': console.log('12$'); break;
                case 'Weekend': console.log('15$'); break;
                case 'Holiday': console.log('5$'); break;
            }
            break;
        case (age > 18 && age <= 64):
            switch(day){
                case 'Weekday': console.log('18$'); break;
                case 'Weekend': console.log('20$'); break;
                case 'Holiday': console.log('12$'); break;
            }
            break;
        case (age > 64 && age <= 122):
            switch(day){
                case 'Weekday': console.log('12$'); break;
                case 'Weekend': console.log('15$'); break;
                case 'Holiday': console.log('10$'); break;
            }
            break;
        default:
            console.log('Error!');
            break;
    }
}

theatrePromotion('Holiday', -12);