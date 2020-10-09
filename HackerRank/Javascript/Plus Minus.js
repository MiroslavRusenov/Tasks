function plusMinus(arr) {
    let countP = 0;
    let countN = 0;
    let countZ = 0;

    for (let r of arr) {
        if (r > 0) countP++;
        else if (r == 0) countZ++;
        else countN++;
    }

    console.log((countP / arr.length).toFixed(6));
    console.log((countN / arr.length).toFixed(6));
    console.log((countZ / arr.length).toFixed(6));
}
