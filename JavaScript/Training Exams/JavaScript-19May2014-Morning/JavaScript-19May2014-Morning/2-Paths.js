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
        var dirs = args[i].split(' ');
        dirsMatrix.push([]);
        visited.push([]);
        points.push([]);
        for (var j = 0; j < cols; j++) {
            dirsMatrix[i - 1][j] = dirs[j];
            visited[i - 1][j] = false;
            points[i - 1][j] = filler;
            filler += 1;
        }
    }
    //return dirsMatrix;
    function inRange(pos, range) {
        return 0 <= pos && pos < range;
    }

    var currentRow = 0;
    var currentCol = 0;
    var sum = 0;

    while (true) {
        if (!inRange(currentRow, rows) || !inRange(currentCol, cols)) {
            return result = 'successed with ' + sum;
        }
        if (visited[currentRow][currentCol]) {
            return result = 'failed at (' + currentRow + ', ' + currentCol + ')';
        }
        visited[currentRow][currentCol] = true;
        sum += points[currentRow][currentCol];

        switch (dirsMatrix[currentRow][currentCol]) {
            case 'dl': currentCol -= 1; currentRow += 1; break;
            case 'dr': currentCol += 1; currentRow += 1; break;
            case 'ul': currentRow -= 1; currentCol -= 1; break;
            case 'ur': currentRow -= 1; currentCol += 1; break;
            default: break;
        }
    }
}

var test = [
  '3 5',
  'dr dl dr ur ul',
  'dr dr ul ur ur',
  'dl dr ur dl ur'
];

var test2 = [
  '3 5',
  'dr dl dl ur ul',
  'dr dr ul ul ur',
  'dl dr ur dl ur'
]


console.log(solve(test));

console.log(solve(test2));


