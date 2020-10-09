function miniMaxSum(arr) {
    let num = arr.shift();
    let min = num;
    let max = num;
    let sum = num;

    for (let r of arr) {
        if (r < min) min = r;
        if (r > max) max = r;
        sum += r;
    }

    console.log((sum - max) + " " + (sum - min));
}
