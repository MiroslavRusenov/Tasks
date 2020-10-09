function timeConversion(s) {
    let format = s.substr(s.length - 2);
    let hours = s.substr(0, 2);
    switch (format) {
        case "AM":
            if (hours >= 12) hours = "00";
            break;
        case "PM":
            if (hours < 12) hours = Number(hours) + 12;
            break;
    }
    return hours + ":" + s.substr(3, 2) + ":" + s.substr(6, 2);
}
