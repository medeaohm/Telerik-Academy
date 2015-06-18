function solve(params) {
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]),
        knightMoves = [[-2, 1], [-1, 2], [1, 2], [2, 1],
                       [2, -1], [1, -2], [-1, -2], [-2, -1]], i, move;

    var table = [];
    var figures = [];
    for (var row = 0; row < rows; row++) {
        table.push([]);
        figures.push([]);
        var fig = params[row + 2];

        for (var col = 0; col < cols; col++) {
            table[row][col] = String.fromCharCode(97 + col) + (rows - row).toString();
            figures[row][col] = fig[col];
        }
    }


    for (var row = 0; row < rows; row++) {
        for (var col = 0; col < cols; col++) {
            // console.log(table[row, col])
        }
    }

    for (i = 0; i < tests; i++) {
        move = params[rows + 3 + i].split(' ');
        var from = move[0];
        var fromC = (from.charCodeAt(0) - 97)*1;
        var fromR = -from[1]*1 + rows;
        var currentFig = figures[fromR][fromC];

        var to = move[1];
        var toC = (to.charCodeAt(0) - 97)*1;
        var toR = -to[1]*1 + rows;
        var nextFig = figures[toR][toC];
        
        if (nextFig != '-') {
            console.log('no');
        }
        else if (currentFig == '-') {
            console.log('no');
        }
        else if (currentFig == 'K') {
            if (validKmove(fromR,fromC,toR,toC)) {
                console.log('yes');
            }
            else {
                console.log('no')
            }
        }
        else if (currentFig == 'Q') {
            if (validQmove(fromR,fromC,toR,toC)) {
                console.log('yes');
            }
            else {
                console.log('no')
            }
        }
    }

    function validKmove(fromR, fromC, toR, toC) {
        if (((Math.abs(toR - fromR) === 2) && (Math.abs(toC - fromC) === 1)) || ((Math.abs(toR - fromR) === 1) && (Math.abs(toC - fromC) === 2))) {
            return true;
        }
        return false;
    }


    function validQmove(fromR, fromC, toR, toC) {
        var free = freepath(fromR, fromC, toR, toC);
        //console.log(free);
        if ((fromR === toR || fromC === toC || Math.abs(fromR - toR) === Math.abs(fromC - toC))) {
            if (free) {
                return true;
            }
            else {
                return false;
            }
        }
        else {
            return false;
        } 
    }

    function freepath(fromR, fromC, toR, toC) {
        var startI = Math.min(fromR+1, toR);
        var endI = Math.max(fromR+1, toR);
        var startJ = Math.min(fromC+1, toC);
        var endJ = Math.max(fromC + 1, toC);
        //console.log(startI);
        //console.log(endI);
        //console.log(startJ);
        //console.log(endJ);

        if (fromR === toR) {
            if (fromC > toC) {
                for (var j = toC; j < fromR; j++) {
                    if (figures[fromR][j] != '-') {
                        return false;
                    }
                }
                return true;
            }
            else {
                for (var j = fromC + 1; j <= toC; j++) {
                    if (figures[fromR][j] != '-') {
                        return false;
                    }
                }
                return true;
            }
        }

        else if (fromC === toC) {
            if (fromR > toR) {
                for (var j = toR; j < fromR; j++) {
                    if (figures[j][fromC] != '-') {
                        return false;
                    }
                }
                return true;
            }
            else {
                for (var j = fromR + 1; j <= toR; j++) {
                    if (figures[j][fromC] != '-') {
                        return false;
                    }
                }
                return true;
            }
        }
        else {
            return true;
        //    var end = Math.min(endI, endJ);
        //    if (toR > fromR && toC > fromC) {
        //        for (var i = 0; i < end; i++) {
        //            if (figures[i + fromR + 1][i + fromC + 1] != '-') {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }
        //    else if (toR > fromR && toC < fromC) {
        //        for (var i = 0; i < end; i++) {
        //            if (figures[i + fromR + 1][i + toC] != '-') {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }

        //    else if (toR < fromR && toC > fromC) {
        //        for (var i = 0; i < end; i++) {
        //            if (figures[i + toR][i + fromC + 1] != '-') {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }
        //    else if (toR < fromR && toC < fromC) {
        //        for (var i = 0; i < end; i++) {
        //            if (figures[i + toR][i + toC] != '-') {
        //                return false;
        //            }
        //        }
        //        return true;
        //    }
        }
    }
}

var test1 = [
    '3',
    '4',
    '--K-',
    'K--K',
    'Q--Q',
    '12',
    'd1 b3',
    'a1 a3',
    'c3 b2',
    'a1 c1',
    'a1 b2',
    'a1 c3',
    'a2 c1',
    'd2 b1',
    'b1 b2',
    'c3 a3',
    'a2 a3',
    'd1 d3'
];

console.log(solve(test1));