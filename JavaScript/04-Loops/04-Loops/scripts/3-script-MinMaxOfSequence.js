// Problem 3. Min/Max of sequence
//
// Write a script that finds the max and min number from a sequence of numbers.

var sequence = [1, 5, -3, 10, 0, 6, 2];

var max = sequence[0];
var min = sequence[0];

var seq = sequence[0];

for (var i = 1; i < sequence.length; i++) {
    seq += ' ' + sequence[i];
    if (sequence[i] > max) {
        max = sequence[i];
    }
    if (sequence[i] < min) {
        min = sequence[i];
    }
}

console.log('Sequence: ' + seq);
console.log('Max = ' + max);
console.log('Min = ' + min);