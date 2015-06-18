// Problem 6. Most frequent number
//
// Write a script that finds the most frequent number in an array.

var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

var current,
    currentCount = 0,
    mostFrequentCount = 0,
    mostFrequent,
    len;


for (var i = 0, len = arr.length; i < len; i += 1) {
    current = arr[i];
    currentCount = 0;
    for (var j = i; j < len; j += 1) {
        if (arr[j] === current) {
            currentCount += 1;
            if (currentCount > mostFrequentCount) {
                mostFrequentCount = currentCount;
                mostFrequent = current;
            }
        }
    }
}

console.log('Array: ' + arr.join(', '));
console.log('The most frequent number is ' + mostFrequent + ' (' + mostFrequentCount + ' times)');