// Problem 9. Point in Circle and outside Rectangle
//
// Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

var x = 1;
var y = 2;

var circleX = 1;
var circleY = 1;
var radius = 3;

var isInsideCircle = ((circleX - x) * (circleX - x)) + ((circleY - y) * (circleY - y)) <= radius * radius;
var isInsideRect = ((x >= -1) && (x <= 5)) && ((y >= -1) && (y <= 1));
var inCircleOutRect = (isInsideCircle && !isInsideRect);

var result = 'The point P(' + x + ' ,' + y + ')';

if (inCircleOutRect) {
    result += ' is inside the circle  K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2)'
}
else {
    result += ' is NOT inside the circle  K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2)'
}

console.log(result);