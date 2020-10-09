function birthdayCakeCandles(ar) {
    let max = 0, count = 0;
    for (let r of ar) if (r > max) max = r;
    for (let r of ar) if (r === max) count++;
    return count;
}
