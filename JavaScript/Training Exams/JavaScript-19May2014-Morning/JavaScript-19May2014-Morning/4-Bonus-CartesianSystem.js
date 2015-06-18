//function s(a) {
//    var x = a[0];
//    var y = a[1];
//    var r;
//    if (x < 0) {
//        if (y < 0) {
//            r = 2;
//        }
//        else {
//            r = 0;
//        }  
//    }
//    else {
//        if (y<0) {
//            r=3;
//        }
//        r = 1;
//    }
//    return r;
//}

var test = [-1, -2];
console.log(s(1,-2));

//function s(a) {
//    var x = a[0],
//        y = a[1],
//        r
//    return x,y < 0 ? r = 2 : x < 0 ? r = 0 : y < 0 ? r = 3 : r = 1
//}

//function Solve(x, y) { return x, y < 0 ? r = 2 : x < 0 ? r = 0 : y < 0 ? r = 3 : r = 1 }
function s(x, y) { return x < 0 ? (y < 0 ? 2 : 0) : (y < 0 ? 3 : 1) };
