// Problem 1. Planar coordinates
//
// Write functions for working with shapes in standard Planar coordinate system.
//      Points are represented by coordinates P(X, Y)
//      Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
// Calculate the distance between two points.
// Check if three segment lines can form a triangle.

function Point (x, y) {
    this.x = x;
    this.y = y;
}

Point.prototype.toString = function () {
    return 'P(' + this.x + ',' + this.y + ')';
}

function Line (Point1, Point2) {
    this.Point1 = Point1;
    this.Point2 = Point2;
}

Line.prototype.toString = function () {
    return 'L(' + this.Point1.toString() + ', ' + this.Point2.toString() + ')';
}

Line.prototype.getDistance = function () {
    var x = (this.Point1.x - this.Point2.x) * (this.Point1.x - this.Point2.x);
    var y = (this.Point1.y - this.Point2.y) * (this.Point1.y - this.Point2.y);

    return Math.sqrt(x + y);
}

function canFormTriangle(a, b, c) {
    return a.getDistance() < b.getDistance() + c.getDistance() &&
           b.getDistance() < c.getDistance() + a.getDistance() &&
           c.getDistance() < a.getDistance() + b.getDistance();
}

var PointA = new Point(1, 1),
    PointB = new Point(3, 2),
    PointC = new Point(1, 2),
    lineAB = new Line(PointA, PointB),
    lineAC = new Line(PointA, PointC),
    lineBC = new Line(PointB, PointC),
    distAB = lineAB.getDistance(),
    distAC = lineAC.getDistance(),
    distBC = lineBC.getDistance();

console.log('Point A = ' + PointA.toString());
console.log('Point B = ' + PointB.toString());
console.log('Point C = ' + PointC.toString());
console.log('Line AB = ' + lineAB + ' -> distance AB = ' + distAB);
console.log('Line AC = ' + lineAC + ' -> distance AC = ' + distAC);
console.log('Line BC = ' + lineBC + ' -> distance BC = ' + distBC);
console.log('Can form triangle from lineAB, lineAC and lineBC? -> ' + canFormTriangle(lineAB, lineAC, lineBC));

