function solve(args) {
    var result;

    var dim = args[0].split(' ');
    var rows = dim[0] * 1;
    var cols = dim[1] * 1;

    var dirsMatrix = [];
    var visited = [];
    var points = [];
    var filler;

    for (var i = 1; i < rows + 1; i++) {
        filler = Math.pow(2, i - 1);
        var dirs = args[i];
        dirsMatrix.push([]);
        visited.push([]);
        points.push([]);
        for (var j = 0; j < cols; j++) {
            dirsMatrix[i - 1][j] = dirs[j];
            visited[i - 1][j] = false;
            points[i - 1][j] = filler;
            filler -= 1;
        }
    }

    function inRange(pos, range) {
        return 0 <= pos && pos < range;
    }

    var currentRow = rows - 1;
    var currentCol = cols - 1;
    var sum = 0;
    var count = 0;

    while (true) {
        if (!inRange(currentRow, rows) || !inRange(currentCol, cols)) {
            return result = 'Go go Horsy! Collected ' + sum + ' weeds';
        }
        if (visited[currentRow][currentCol]) {
            return result = 'Sadly the horse is doomed in ' + count + ' jumps';
        }
        visited[currentRow][currentCol] = true;
        sum += points[currentRow][currentCol];
        count += 1;

        switch (dirsMatrix[currentRow][currentCol]) {
            case '1': currentRow -= 2; currentCol += 1; break;
            case '2': currentRow -= 1; currentCol += 2; break;
            case '3': currentRow += 1; currentCol += 2; break;
            case '4': currentRow += 2; currentCol += 1; break;
            case '5': currentRow += 2; currentCol -= 1; break;
            case '6': currentRow += 1; currentCol -= 2; break;
            case '7': currentRow -= 1; currentCol -= 2; break;
            case '8': currentRow -= 2; currentCol -= 1; break;
            default: break;
        }
    }
}

var test1 = [
  '3 5',
  '54561',
  '43328',
  '52388',
];
console.log(solve(test1));

var test2 = [
  '3 5',
  '54361',
  '43326',
  '52188',
];
console.log(solve(test2));
