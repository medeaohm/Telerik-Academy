// Problem 6. Extract text from HTML
//
// Write a function that extracts the content of a html page given as text.
// The function should return anything that is in a tag, without the tags.

var sampleHTML = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';
var parsedText = extractTextFromHtml(sampleHTML);
console.log('Original text: ' + sampleHTML);
console.log('Only the text: ' + parsedText);

function extractTextFromHtml(text) {
    text = text.replace(/(\r\n|\n|\r|\t)/g, '');
    text = text.replace(/<[^>]*>/g, '');
    return text;
}