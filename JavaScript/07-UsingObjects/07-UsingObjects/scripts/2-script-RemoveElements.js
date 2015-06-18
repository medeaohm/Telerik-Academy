// Problem 2. Remove elements
//
// Write a function that removes all elements with a given value.
// Attach it to the array type.
// Read about prototype and how to attach methods.


Array.prototype.remove = function (elementValue) {
    for (var i = 0; i < this.length; i++) {
        if (this[i] === elementValue) {
            this.splice(i, 1);
            i--;
        }
    }
}

Array.prototype.toString = function () {
    var result = '[' + this.join(', ') + ']' + ' -> type of elements: [';
    for (var i = 0; i < this.length; i++) {
        if (i === this.length-1) {
            result += typeof (this[i]) + ']';
        }
        else {
            result += typeof (this[i]) + ', ';
        }
    }
    return result;
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

console.log('Original array: \n' + arr.toString());
arr.remove(1);
console.log('\nAfter removing elements with value 1:\n' + arr.toString());