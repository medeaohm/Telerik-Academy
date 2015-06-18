function solve(args) {
    var result;

    var dim = args[0].split(' ');
    var rows = dim[0] * 1;
    var cols = dim[1] * 1;

    var start = args[1].split(' ');
    var startRow = start[0] * 1;
    var startCol = start[1] * 1;

    var dirsMatrix = [];
    var visited = [];
    var points = [];
    var filler = 1;

    for (var i = 2; i < rows+2; i++) {
        var dirs = args[i];
        dirsMatrix.push([]);
        visited.push([]);
        points.push([]);
        for (var j = 0; j < cols; j++) {
            dirsMatrix[i - 2][j] = dirs[j];
            visited[i - 2][j] = false;
            points[i - 2][j] = filler;
            filler += 1;
        }
    }
    //return points;
    //return result = startRow + ' ' + startCol + ' ' + dirsMatrix[startRow][startCol] + ' ' + dirsMatrix;
    
    function inRange(pos, range) {
        return 0 <= pos && pos < range;
    }

    var currentRow = startRow;
    var currentCol = startCol;
    var sum = 0;
    var count = 0;

    while (true) {
        if (!inRange(currentRow, rows) || !inRange(currentCol, cols)) {
            return result = 'out ' + sum;
        }
        if (visited[currentRow][currentCol]) {
            return result = 'lost ' + count;
        }
        visited[currentRow][currentCol] = true;
        count += 1;
        sum += points[currentRow][currentCol];

        switch (dirsMatrix[currentRow][currentCol]) {
            case 'l': currentCol -= 1; break;
            case 'r': currentCol += 1; break;
            case 'u': currentRow -= 1; break;
            case 'd': currentRow += 1; break;
            default: break;
        }
    }
}

var test = [
 "3 4",
 "1 3",
 "lrrd",
 "dlll",
 "rddd"];

var test2 = [
 "5 8",
 "0 0",
 "rrrrrrrd",
 "rludulrd",
 "durlddud",
 "urrrldud",
 "ulllllll"];

var test3 = [
 "5 8",
 "0 0",
 "rrrrrrrd",
 "rludulrd",
 "lurlddud",
 "urrrldud",
 "ulllllll"]



console.log(solve(test));
console.log(solve(test2));
console.log(solve(test3));