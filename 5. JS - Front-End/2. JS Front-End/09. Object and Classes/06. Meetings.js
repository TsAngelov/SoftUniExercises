function arrangeMeetings(input){
    const meetingList = {};

    input.forEach(meeting => {
        const [weekday, name] = meeting.split(' ');
        
        if(meetingList.hasOwnProperty(weekday)){
            console.log(`Conflict on ${weekday}!`);
        }
        else{
            meetingList[weekday] = name;
            console.log(`Scheduled for ${weekday}`);
        }
    });

    for (weekday in meetingList){
        console.log(`${weekday} -> ${meetingList[weekday]}`);
    }
}

arrangeMeetings(['Monday Peter', 'Wednesday Bill', 'Monday Tim', 'Friday Tim']);