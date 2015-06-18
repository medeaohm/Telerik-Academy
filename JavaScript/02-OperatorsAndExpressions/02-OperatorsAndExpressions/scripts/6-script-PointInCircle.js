// Problem 6. Point in Circle
//
// Write an expression that checks if given point P(x, y) is within a circle K(O, 5).

var x = 1;
var y = 1;

var centerX = 0;
var centerY = 0;
var radius = 5;

var isInside = ((centerX - x) * (centerX - x)) + ((centerY - y) * (centerY - y)) <= radius * radius;

var result = 'The point P(' + x + ' ,'+ y + ')';

if (isInside) {
    result += ' is inside the circle K(O, 5)'
}
else {
    result += ' is NOT inside the circle K(O, 5)'
}

console.log(result);