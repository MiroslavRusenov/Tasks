function diagonalDifference(arr) {
    let diagL = 0;
    let diagR = 0;

    for (let i = 0; i < arr.length; i++) {
        diagL += arr[i][i];
        diagR += arr[arr.length - 1 - i][i];
    }
    return Math.abs(diagL - diagR);
}
