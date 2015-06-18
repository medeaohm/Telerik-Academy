//function solve(params) {
//    var s = params[0];
//    var array = s.split(' ');

//    var n = array.length;
//    var result = 0;
//    var last = parseInt(array[0]);

//    for (var i = 1; i < n; i++) {
//        var current = parseInt(array[i]);
//        if (current >= last) {
//            result++;
//        }
//        last = current;
//    }
//    return result;
//}


function solve(params) {
    var s = params[0];
    var array = s.split(' ').map(Number);

    var n = array.length;
    var result = 1;
    var max = 0;
    var picks = [];
    var indPicks = [];
    picks[0] = 1;
    picks[1] = 0;
    picks[n - 2] = 0;
    picks[n - 1] = 1;

    for (var i = 2; i < n - 2; i++) {

        if (array[i] > array[i+1] && array[i] > array[i-1]) {
            picks[i] = 1;
        }
        else {
            picks[i] = 0;
        }
    }
    for (var i = 0; i < n; i++) {
        if (picks[i] === 0) {
            result++;
        }
        else {
            result = 1;
        }
        if (result > max) {
            max = result;
        }
    }
    
    return max;
}

var test1 = ['5 1 7 6 3 6 4 2 3 8'];
var test2 = ['5 1 7 4 8'];
var test3 = ['10 1 2 3 4 5 4 3 2 1 10'];
var test4 = ['1 2 1 2 3 5'];
console.log(solve(test1));
console.log(solve(test2));
console.log(solve(test3));
console.log(solve(test4));