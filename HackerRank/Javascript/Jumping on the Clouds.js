function jumpingOnClouds(c) {
    let jumps = 0;

    for (let i = 0; i < c.length; i++) {
        if (c[i] + c[i + 2] === 0) {
            jumps++;
            i += 1;
        } else if (c[i] + c[i + 1] === 0) {
            jumps++;
        }
    }

    return jumps;
}
