// Problem 8. Replace tags
//
// Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

var text = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
var replacedTagsText = replaceTags(text);

console.log('Original text: ' + text);
console.log('Text with replaced tags: ' + replacedTagsText);

function replaceTags(text) {
    var result;
    result = text.replace(/<[^>]a>/g, '[/URL]');
    result = result.replace(/<a href=\"/g, '[URL=');
    result = result.replace(/\">/g, ']');
    return result;
}