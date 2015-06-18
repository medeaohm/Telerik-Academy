/*
 * Write a function that sums an array of numbers:
 * Numbers must be always of type Number
 * Returns null if the array is empty
 * Throws Error if the parameter is not passed (undefined)
 * Throws if any of the elements is not convertible to Number
 */

function solve(arr) {
    if (arr == undefined) {
        throw 'Function argument missing'
    }
    else if (!arr.length) {
        return null;
    }
    else {
        var sum = 0,
        i = 0,
        length = arr.length;

        for (i; i < length; i += 1) {
            if (isNaN(parseInt(arr[i]))) {
                throw 'Function argument is not a number'
            }
            sum += parseInt(arr[i]);
        }
        return sum;
    }
}

var test = [1, 2, 3, 4];
console.log(solve(test));
