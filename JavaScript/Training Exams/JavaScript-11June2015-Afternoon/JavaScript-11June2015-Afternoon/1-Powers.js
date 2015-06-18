function solve(params) {
    var nk = params[0].split(' ').map(Number),
        s = params[1].split(' ').map(Number),
        result = 0;
    var n = nk[0],
        numTrans = nk[1]*1,
        trans = [];

    for (var i = 0; i < numTrans; i++) {
        for (var j = 0; j < n; j++) {
            if (s[j] === 0) {
                if (j == 0) {
                    trans[j] = Math.abs(s[n - 1] - s[1]);
                }
                else if (j == n-1) {
                    trans[j] = Math.abs(s[n-2] - s[0]);
                }
                else {
                    trans[j] = Math.abs(s[j - 1] - s[j + 1]);
                }
                //console.log(j + ' ' + s[j] + ' ' + trans[j]);
            }
            
            else if (s[j] == 1) {
                if (j == 0) {
                    trans[j] = s[n-1] + s[1];
                }
                else if (j == n - 1) {
                    trans[j] = s[n-2] + s[0];
                }
                else {
                    trans[j] = s[j-1] + s[j+1];
                }
                //console.log(j + ' ' + s[j] + ' ' + trans[j]);
            }
            //else {
            //    trans[j] = s[j];
            //    console.log(j + ' ' + s[j] + ' ' + trans[j]);
            //}
            else if (!(s[j] % 2)) {
                if (j == 0) {
                    trans[j] = Math.max(s[1], s[n-1]);
                }
                else if (j == n - 1) {
                    trans[j] = Math.max(s[n-2], s[0]);
                }
                else {
                    trans[j] = Math.max(s[j - 1], s[j + 1]);
                }
            }
            else {
                if (j == 0) {
                    trans[j] = Math.min(s[1], s[n - 1]);
                }
                else if (j == n - 1) {
                    trans[j] = Math.min(s[n - 2], s[0]);
                }
                else {
                    trans[j] = Math.min(s[j - 1], s[j + 1]);
                }
            }   
        }
        for (var k = 0; k < n; k++) {
            s[k] = trans[k];
        }
        //console.log(s)
    }
    
    for (var i = 0; i < n; i++) {
        result += trans[i];
    }
    return result;
}


var test = [
    '5 1',
    '9 0 1 4 1'
];

var test2 = [
    '10 3',
    '1 9 1 9 1 9 1 9 1 9'
];

var test3 = [
    '10 10',
    '0 1 2 3 4 5 6 7 8 9'
];

console.log(solve(test));
console.log(solve(test2));
console.log(solve(test3));
