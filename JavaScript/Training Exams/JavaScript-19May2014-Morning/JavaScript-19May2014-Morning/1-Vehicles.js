function solve(params) {
    var s = params*1;
    var count = 0;

    var maxCars = Math.floor(s / 4);
    var maxTrucks = Math.floor(s / 10);
    var maxTrikes = Math.floor(s / 3);

    for (var i = 0; i <= maxTrikes; i++) {
        for (var j = 0; j <= maxCars; j++) {
            for (var k = 0; k <= maxTrucks; k++) {
                if ((i*3 + j*4 +k*10)===s){
                    count += 1;
                }
            }
        }
    }

    return count;
}
console.log(solve(40));