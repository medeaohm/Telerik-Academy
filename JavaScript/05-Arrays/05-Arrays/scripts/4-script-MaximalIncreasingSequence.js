// Problem 4. Maximal increasing sequence
//
// Write a script that finds the maximal increasing sequence in an array.

var arr = [3, 2, 3, 4, 2, 2, 4];

var count = 1,
    maxCount = count,
    sequenceStart;

for (var i = 1; i < arr.length; i += 1) {

    if (arr[i] > arr[i - 1]) {
        count++;
    }
    else {
        count = 1;
    }

    if (count > maxCount) {
        maxCount = count;
        sequenceStart = i + 1 - maxCount;;
    }
}

var finalArray = [];
for (var i = sequenceStart; i < sequenceStart + maxCount; i++) {
    finalArray[i - sequenceStart] = arr[i];
}

console.log('Initial array = ' + arr.join(', '));
console.log('Maximal Increasing sequence = ' + finalArray.join(', '));
