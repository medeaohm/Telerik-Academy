// Problem 7. Binary search 
//
//  Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

var array = [1, 2, 3, 9, 25, 14, 6, 70, 20, 50];

console.log('Array: ' + array.join(', '));
console.log('Number: 10 at position: ' + binarySearch(array, 10, 0, array.length));
console.log('Number: 20 at position: ' + binarySearch(array, 20, 0, array.length));
console.log('Number: 3 at position: ' + binarySearch(array, 3, 0, array.length));

function binarySearch(arr, num, min, max) {
    if (max < min) {
        return -1;
    }

    var mid = min + Math.floor((max - min) / 2);

    if (arr[mid] > num) {
        return binarySearch(arr, num, min, mid - 1);
    }
    else if (arr[mid] < num) {
        return binarySearch(arr, num, mid + 1, max);
    }
    else {
        return mid;
    }
}