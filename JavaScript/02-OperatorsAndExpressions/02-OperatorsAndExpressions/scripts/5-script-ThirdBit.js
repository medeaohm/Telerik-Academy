

var n = 15;
var p = 3;
var mask = 1 << p;
var nAndMask = n & mask;
var thirdBit = nAndMask >> p;

var result = 'The third bit of ' + n + ' is ';
if (thirdBit) {
    result += 1;
}
else {
    result += 0;
}

console.log(result);