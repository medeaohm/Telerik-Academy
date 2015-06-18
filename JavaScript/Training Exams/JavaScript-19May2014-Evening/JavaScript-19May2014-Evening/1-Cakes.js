function solve(params) {
    var s = params[0] * 1, c1 = params[1] * 1, c2 = params[2] * 1, c3 = params[3] * 1;
    var answer = 0;


    for (var i = 0; i <= s/c1 + 1; i++) {
        for (var j = 0; j <= s / c2 + 1; j++) {
            for (var k = 0; k <= s / c3 + 1; k++) {
                var temp = (i * c1) + (j * c2) + (k * c3);
                //console.log(temp);
                if (temp > answer && temp <= s) {
                    answer = temp;
                }
            }
        }
    }
    return answer;
}

var test = [
    110,
    13,
    15,
    17
];

var test2 = [
    20,
    11,
    200,
    300
];

var test3 = [
    110,
    19,
    29,
    39
];

console.log(solve(test));
console.log(solve(test2));
console.log(solve(test3));