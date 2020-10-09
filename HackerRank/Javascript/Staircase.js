function staircase(n) {
    let str = "";
    for (let i = 1; i <= n; i++) str += "".padStart(n - i) + "#".repeat(i) + "\n";
    console.log(str);
}
