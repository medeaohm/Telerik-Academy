function Solve(params) {
    var rows = params[0] | 0;
    var cols = params[1] | 1;
    var coordBoard = [], board, row, col, move, j;
    var letters = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
        'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z']
    var moves = params.slice(rows + 3);

    //create the board of the coordinates
    for (row = rows; row >= 1; row--) {
        coordBoard[rows - row] = [];

        for (col = 0; col < cols; col++) {
            var colLetter = letters[col].toLocaleLowerCase();
            var coord = colLetter + row;
            coordBoard[rows - row][col] = coord;
        }
    }

    board = params.slice(2, 2 + rows);

    for (move = 0; move < moves.length; move++) {
        if (move == moves.length - 1) {
            debugger;
        }

        var moveEntities = moves[move].split(' ');
        var startPos = moveEntities[0];
        var startRow = rows - parseInt(startPos[1]);
        var startCol = letters.indexOf(startPos[0].toUpperCase());

        var endPos = moveEntities[1];
        var endRow = rows - parseInt(endPos[1]);
        var endCol = letters.indexOf(endPos[0].toUpperCase());

        if (startRow == endRow && startCol == endCol) {
            console.log('no');
            continue;
        }

        var figure = board[startRow][startCol];

        if (figure === '-') { //no piece to move
            console.log('no');
        } else { //there is piece to move
            switch (figure) {
                case 'R':
                    if (validateRookMove(startRow, startCol, endRow, endCol)) {
                        console.log('yes');
                    } else {
                        console.log('no');
                    }
                    break;
                case 'B':
                    if (validateBishopMove(startRow, startCol, endRow, endCol)) {
                        console.log('yes');
                    } else {
                        console.log('no');
                    }
                    break;
                case 'Q':
                    if (validateRookMove(startRow, startCol, endRow, endCol) ||
                        validateBishopMove(startRow, startCol, endRow, endCol)) {
                        console.log('yes');
                    } else {
                        console.log('no');
                    }
                    break;
            }
        }
    }

    function validateRookMove(startRow, startCol, endRow, endCol) {
        //the rook will move vertically
        if (startCol === endCol) {
            var cellsEmpty = true;

            if (startRow > endRow) {
                for (j = startRow - 1; j >= endRow; j--) {
                    if (board[j][startCol] !== '-') {
                        cellsEmpty = false;
                        break;
                    }
                }
            }
            else if (startRow < endRow) {
                for (j = startRow + 1; j <= endRow; j++) {
                    if (board[j][startCol] !== '-') {
                        cellsEmpty = false;
                        break;
                    }
                }
            }
            return cellsEmpty;

            //the rook will move horizontally
        } else if (startRow === endRow) {
            var cellsEmpty = true;

            if (startCol > endCol) {
                for (j = startCol - 1; j >= endCol; j--) {
                    if (board[startRow][j] !== '-') {
                        cellsEmpty = false;
                        break;
                    }
                }
            }
            else if (startCol < endCol) {
                for (j = startCol + 1; j <= endCol; j++) {
                    if (board[startRow][j] !== '-') {
                        cellsEmpty = false;
                        break;
                    }
                }
            }
            return cellsEmpty;

        } else {
            return false;
        }
    }

    function validateBishopMove(startRow, startCol, endRow, endCol) {
        //the bishop will move right-up
        if (Math.abs(startRow - endRow) == Math.abs(startCol - endCol) &&
            startRow > endRow && startCol < endCol) {
            var emptyCells = true;
            var offset = 0;

            for (j = startRow - 1; j >= endRow; j--) {
                offset++;
                if (board[j][startCol + offset] !== '-') {
                    emptyCells = false;
                    break;
                }
            }
            return emptyCells;

        } else if (Math.abs(startRow - endRow) == Math.abs(startCol - endCol) &&
            startRow > endRow && startCol > endCol) { //the bishop will move left up
            var emptyCells = true;
            var offset = 0;

            for (j = startRow - 1; j >= endRow; j--) {
                offset++;
                if (board[j][startCol - offset] !== '-') {
                    emptyCells = false;
                    break;
                }
            }
            return emptyCells;

        } else if (Math.abs(startRow - endRow) == Math.abs(startCol - endCol) &&
            startRow < endRow && startCol < endCol) { //the bishop will move right down
            var emptyCells = true;
            var offset = 0;

            for (j = startRow + 1; j <= endRow; j++) {
                offset++;
                if (board[j][startCol + offset] !== '-') {
                    emptyCells = false;
                    break;
                }
            }
            return emptyCells;

        } else if (Math.abs(startRow - endRow) == Math.abs(startCol - endCol) &&
            startRow < endRow && startCol > endCol) { //the bishop will move left down
            var emptyCells = true;
            var offset = 0;

            for (j = startRow + 1; j <= endRow; j++) {
                offset++;
                if (board[j][startCol - offset] !== '-') {
                    emptyCells = false;
                    break;
                }
            }
            return emptyCells;

        } else {
            return false;
        }
    }
}