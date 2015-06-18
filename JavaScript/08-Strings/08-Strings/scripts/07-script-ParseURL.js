// Problem 7. Parse URL
//
// Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
// Return the elements in a JSON object.

var url = 'http://telerikacademy.com/Courses/Courses/Details/239';
var urlParsed = parseURL(url);

console.log(url);
console.log(urlParsed);

function parseURL(url) {

    var result;
    var protocol = url.substr(0, url.indexOf(':'));
    var remaining = url.substr((url.indexOf(':') + 3));
    var server = remaining.substr(0, remaining.indexOf('/'));
    var resource = remaining.substr(remaining.indexOf('/'));

    return result = '[protocol] = ' + protocol + '\n[server] = ' + server + '\n[resource] = ' + resource;
}

