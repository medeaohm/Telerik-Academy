// Problem 6. Quadratic equation
// 
// Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
// Calculates and prints its real roots.
// Note: Quadratic equations may have 0, 1 or 2 real roots.

var a = 2;
var b = 5;
var c = -3;

console.log('Equation:');
console.log(a + 'x^2 + ' + b + 'x + ' + c);

var root1;
var root2;

if (((b*b)-(4*a*c)) < 0) {
    console.log('No real roots');
}
else if (((b * b) - (4 * a * c)) === 0) {
    root1 = -b / (2 * a);
    console.log('Root: x = ' + root1);
}
else {
    root1 = (-b + Math.sqrt(((b * b) - (4 * a * c)))) / (2 * a);
    root2 = (-b - Math.sqrt(((b * b) - (4 * a * c)))) / (2 * a);
    console.log('Roots: x1 = ' + root1 + '  x2 = ' + root2);
}