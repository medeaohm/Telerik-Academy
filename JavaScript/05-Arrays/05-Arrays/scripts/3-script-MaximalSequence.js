// Problem 3. Maximal sequence
//
// Write a script that finds the maximal sequence of equal elements in an array.


var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];

var count = 1,
    maxCount = count,
    val;

for (var i = 1; i < arr.length; i += 1) {

    if (arr[i] === arr[i - 1]) {
        count++;
    }
    else {
        count = 1;
    }

    if (count > maxCount) {
        maxCount = count;
        val = arr[i];
    }
}

var finalArray = [];
for (var i = 0; i < maxCount; i++) {
    finalArray[i] = val;
}

console.log('Initial array = ' + arr.join(', '));
console.log('Maximal sequence = ' + finalArray.join(', '));
