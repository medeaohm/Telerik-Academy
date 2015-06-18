// Problem 3. Occurrences of word
//
// Write a function that finds all the occurrences of word in a text.
// The search can be case sensitive or case insensitive.
// Use function overloading.

var text = 'bla bla BLA Bla BlA bla Bla';

console.log('Text: ' + text);
console.log('Occurrene of "bla" (case insensitive): ' + occuranceCount(text, 'bla', false));
console.log('Occurrene of "bla" (case sensitive): ' + occuranceCount(text, 'bla', true));

function occuranceCount(text, word, caseSensitive) {

    var textNoPunct = text.replace(/\W+/g, ' ');

    if (!caseSensitive) {
        textNoPunct = textNoPunct.toLowerCase();
        word = word.toLowerCase();
    }

    var words = textNoPunct.split(' '),
        occurrences = 0;

    for (var i = 0; i < words.length; i+=1) {
        if (words[i] === word) {
            occurrences += 1;
        }
    }
    return occurrences;
}