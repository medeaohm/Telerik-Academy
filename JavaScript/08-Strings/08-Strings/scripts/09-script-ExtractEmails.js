// Problem 9. Extract e-mails
//
// Write a function for extracting all email addresses from given text.
// All sub-strings that match the format @… should be recognized as emails.
// Return the emails as array of strings.

var text = 'Hi! My email @ yahoo is myemail@yahoo.com . I also have 101mailGO@mail_provider.co.uk ! You can write me to my work-email too: work_mail@privider.at.my.work';
var emails = extractEmail(text);

console.log('Original text: ' + text);
console.log('Extracted emails: ' + emails);

function extractEmail(text) {
    var email = [];
    var splittedText = text.split(' ');
    var regExpression = /^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i;

    for (var i = 0; i < splittedText.length; i++) {
        if (regExpression.test(splittedText[i])) {
            email.push(splittedText[i]);
        }
    }

    return email.join(', ');
}