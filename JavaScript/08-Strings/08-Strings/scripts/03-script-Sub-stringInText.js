// Problem 3. Sub-string in text

// Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

var text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
var target = 'in';

function findSubstring(textOriginal, substringTargetOriginal) {
    var text = textOriginal.toLowerCase();
    var substringTarget = substringTargetOriginal.toLowerCase();
    var count = 0;

    for (var i = 0; i < text.length - substringTarget.length; i++) {
        var substr = text.substr(i, substringTarget.length);
        if (substr === substringTarget) {
            count += 1;
        }
    }
    return count;
}

console.log('The target sub-string is: ' + target);
console.log(text);
console.log('The result is: ' + findSubstring(text, target));