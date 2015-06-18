// Problem 1. Format with placeholders
//      Write a function that formats a string. The function should have placeholders, as shown in the example
//          Add the function to the String.prototype

String.prototype.format = function (options) {
    var option,
        regex,
        formatted = this;
    for (option in options) {
        regex = new RegExp('#{' + option + '}', 'g');
        formatted = formatted.replace(regex, options[option]);
    }
    return formatted;
};


console.log('Hello, #{name}! How are you?'.format({ name: 'Pesho' }));
console.log('My name is #{name} and I am #{age} years old'.format({ name: 'Gosho', age: 25 }));