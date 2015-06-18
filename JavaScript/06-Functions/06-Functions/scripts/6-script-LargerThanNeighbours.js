// Problem 6. Larger than neighbours
//
// Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).

var array = [1, 2, 3, 1, 5, 9, 4, 1, 1, 1];
console.log('Array: ' + array.join(', '));
console.log(largerThanNeighbours(array, 5))

function largerThanNeighbours(arr, index) {
    var isLarger = false;
    var result = 'The element at position ' + index + ' is larger than neighbours? --> ';

    if (index <= 0 || index >= arr.length-1) {
        result += 'Invalid index';
    }
    else {
        if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1]) {
            isLarger = true;
        }
        result +=  isLarger;
    }
    return result;
}