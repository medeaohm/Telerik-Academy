// Problem 10. Find palindromes
//
// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

var text = 'abba lamal,joy: monday exe.';
var pal = extractPalindromes(text);

console.log('Text: ' + text);
console.log('Palindromes: ' + pal);

function extractPalindromes(text) {
    var palindromes = [];
    var words = text.match(/\b\w+\b/g);

    for (var ind in words) {
        if (isPlaindrome(words[ind])) {
            palindromes.push(words[ind]);
        }
    }

    return palindromes.join(', ');
}

function isPlaindrome(word) {
    for (var ind = 0; ind < word.length / 2; ind++) {
        if (word[ind] !== word[word.length - ind - 1]) {
            return false;
        }
    }
    return true;
}