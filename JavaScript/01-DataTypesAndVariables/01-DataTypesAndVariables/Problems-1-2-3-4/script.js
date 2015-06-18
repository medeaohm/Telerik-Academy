// 1.Assign all the possible JavaScript literals to different variables.
// 
// 3.Try typeof on all variables you created.
// 
// 4.Create null, undefined variables and try typeof on them.

console.log('Problems 1, 3 and 4:');

var number = 3;
var float = 3.3;
var string = 'Hello JavaScript!';
var arr = [1, 2, 3];
var func = function () { return; };
var nullValue = null;
var undefValue = undefined;
var boolean = true;

function toPrint(obj) {
    var print = obj + ' -> ' + typeof (obj);
    return print;
}

var allLiterals = [number, float, string, arr, func, nullValue, undefValue, boolean];

for (var literal in allLiterals) {
    console.log(toPrint(allLiterals[literal]));
}

console.log('\n');


// Problem 2. Quoted text :Create a string variable with quoted text in it.
console.log('And now the Problem 2. "Quoted text"');

var quoted1 = 'This is a "quoted string"';
var quoted2 = "This is another 'quoted string'";
var quoted3 = 'Another way to \'quote a string\'';

var quotes = [quoted1, quoted2, quoted3];

for (var quote in quotes) {
    console.log(quotes[quote]);
}
