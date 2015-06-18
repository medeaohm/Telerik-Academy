// Problem 4. Lexicographically smallest
//
// Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

console.log('window');
getProperties(window);

console.log('navigator');
getProperties(navigator);

console.log('document');
getProperties(document);

function getProperties(obj) {
    var min = 'zzz';
    var max = ' ';

    for (var property in obj) {
        if (property < min) {
            min = property;
        }

        if (property > max) {
            max = property;
        }
    }

    console.log('min: ' + min);
    console.log('max: ' + max + '\n\r');
}