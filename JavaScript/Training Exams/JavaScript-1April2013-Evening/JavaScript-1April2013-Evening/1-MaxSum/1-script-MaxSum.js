function Solve(params) {
    var n = parseInt(params[0]);
    var answer = -2000000;
    var currentSum = 0;
    
    for (var i = 1; i < n; i++) {
        if (currentSum <= 0) {
            currentSum = 0;
        }

        currentSum += params[i]*1;

        if (currentSum > answer) {
            answer = currentSum;
        }
    }
    return answer;
}

var test = [
    '8',
    '1',
    '6',
    '-9',
    '4',
    '4',
    '-2',
    '10',
    '-1',
];

console.log(Solve(test));