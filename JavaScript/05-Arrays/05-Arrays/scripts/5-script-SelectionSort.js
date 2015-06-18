// Problem 5. Selection sort
//
// Sorting an array means to arrange its elements in increasing order.
// Write a script to sort an array.
// Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
//    Hint: Use a second array

var arr = [5, 1, 8, 3, 0, 9, 4];
var temp;

console.log('Before sorting: ' + arr.join(', '));

for (i = 0, len = arr.length; i < len; i += 1) {
    for (j = i + 1; j < len; j += 1) {
        if (arr[i] > arr[j]) {
            temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}

console.log('After sorting: ' + arr.join(', '));