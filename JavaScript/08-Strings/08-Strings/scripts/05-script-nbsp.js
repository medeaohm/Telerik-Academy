// Problem 5. nbsp
//
// Write a function that replaces non breaking white-spaces in a text with &nbsp;

var text = 'Hello everybody! I\'ve just wrote a function that replaces non breaking white-spaces in a text with &nbsp;';
console.log('Original text: ' + text);

var transformedText = replaceEmptySpaces(text);
console.log('After replacing: ' + transformedText);

function replaceEmptySpaces(text) {
    text = text.replace(/ /g, '&nbsp');
    return text;
}