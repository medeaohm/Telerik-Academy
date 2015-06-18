function solve(args) {

    function inRange(pos, range) {
        return 0 <= pos && pos < range;
    }

    var mnj = args[0].split(' ');
    var n = parseInt(mnj[0]);
    var m = parseInt(mnj[1]);
    var jumps = parseInt(mnj[2]);

    var start = args[1].split(' ');
    var row = start[0]*1;
    var column = start[1]*1;

    var dirsArr = args.slice(2);
    var dirs = [dirsArr.length];
    for (var i = 0; i < dirsArr.length; i++) {
        var dir = dirsArr[i].split(" ");
        dirs[i] = {
            row: parseInt(dir[0]),
            column: parseInt(dir[1])
        }
    }
  
    var used = {};
    var sum = 0;
    var dir = 0;
    var count = 0;
    while (true) {
        if (!inRange(row, n) || !inRange(column, m)) {
            return "escaped " + sum;
        }
        if (used[row * m + column]) {
            return "caught " + count;
        }
        count++;
        used[row * m + column] = true;
        sum += row * m + column + 1;
        row += dirs[dir].row;
        column += dirs[dir].column;
        dir++;
        dir %= dirs.length;
    }
}



 var test = [
    '6 7 3',
    '0 0',
    '2 2',
    '-2 2',
    '3 -1'
 ];
 console.log(test.toString());
 var result = solve(test);
 console.log(result);
