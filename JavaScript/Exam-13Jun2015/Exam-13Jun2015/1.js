function solve(params) {
    var n = parseInt(params[0]);
    var k = parseInt(params[1]);
    var array = (params[2].split(' ')).map(Number);
    var currentMax = -1000000000 ,
        currentMin = 1000000000;
    var result = [];

    for (var i = 0; i < n-k+1; i++) {
        for (var j = i; j <i+  k; j++) {
            if (array[j] > currentMax){
                currentMax = array[j];
            }
            if (array[j] < currentMin) {
                currentMin = array[j];
            }  
        }
        var sum = currentMax + currentMin;
        result.push(sum);
        currentMax = -1000000000;
        currentMin = 1000000000;
    }
    var resStr=result.join(',');
    return resStr;
}

var test1 = [
    '4',
    '2', 
    '1 3 1 8'
];
var test2 = [
    '5',
    '3',
    '7 7 8 9 10'
];
var test3 = [
    '8',
    '4',
    '1 8 8 4 2 9 8 11'
];

console.log(solve(test1));
console.log(solve(test2));
console.log(solve(test3));