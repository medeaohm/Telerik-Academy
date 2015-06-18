// Problem 2. Correct brackets
//
// Write a JavaScript function to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

var correctExpr = '((a+b)/5-d)';
var incorrectExpr = ')(a+b))';

function expressionIsCorrect(expr) {
    var countBrackets = 0;
    var result;

    for (var i = expr.length - 1; i >= 0; i--) {
        if (expr[i] === '(') {
            countBrackets += 1;
        }
        if (expr[i] === ')') {
            countBrackets -= 1;
        }
    }

    if (countBrackets === 0) {
        result = 'correct';
    }
    else {
        result = 'incorrect';
    }

    return result;
}

console.log(correctExpr + ' -> ' + expressionIsCorrect(correctExpr));
console.log(incorrectExpr + ' -> ' + expressionIsCorrect(incorrectExpr));