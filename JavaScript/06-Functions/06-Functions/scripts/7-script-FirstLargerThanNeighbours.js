// Problem 7. First larger than neighbours
//
// Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
// Use the function from the previous exercise.

var array = [1, 2, 3, 1, 5, 9, 4, 1, 1, 1]; // Index of first element larger than neighbourds = 2
//var array = [1, 2, 3, 4, 5]; // no element larger than neighbourds
console.log('Array: ' + array.join(', '));
console.log('Index of the first element larger than neighbours: ' + firstLargerThanNeighbours(array));

function firstLargerThanNeighbours(arr) {
    var indexOfFirstLarger = -1;
    
    for (var index = 1; index < arr.length - 1; index++) {
        if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1]) {
            indexOfFirstLarger = index;
            return indexOfFirstLarger;
        }
    }
    return indexOfFirstLarger
}