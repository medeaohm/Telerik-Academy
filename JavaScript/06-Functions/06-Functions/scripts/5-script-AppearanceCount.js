// Problem 5. Appearance count

// Write a function that counts how many times given number appears in given array.
// Write a test function to check if the function is working correctly.

var array = [1, 1, 2, 5, 1, 5, 2, 2, 6, 6, 6, 6, 8, 3, 3, 3];
testAppearanceCount();

function appearanceCount(arr, number) {
    var count = 0;
    var result;

    for (var element in arr) {
        if (arr[element] === number) {
            count += 1;
        }
    }
    return result = 'The number ' + number + ' appears ' + count + '  times in the array';
}

function testAppearanceCount() {
    console.log('Array: ' + array.join(', '));
    console.log(appearanceCount(array, 1));
    console.log(appearanceCount(array, 2));
    console.log(appearanceCount(array, 5));
    console.log(appearanceCount(array, 6));
    console.log(appearanceCount(array, 3));
    console.log(appearanceCount(array, 8));
    console.log(appearanceCount(array, 10));
}