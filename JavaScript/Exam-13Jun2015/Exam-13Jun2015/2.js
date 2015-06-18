function solve(args) {
    var comprText,
        encText,
        text = args[0],
        offset = parseInt(args[1]),
        CONSTANTS = {
            ALPHABET: 'abcdefghijklmnopqrstuvwxyz'
        }

    function compress (message) {
    var res = '';
    var indexInMessage = 0;
    
    while (indexInMessage < message.length) {
        var currentSymbol = message[indexInMessage];
        var scanIndex = indexInMessage + 1;
        var repeatLength = 1;
        while (scanIndex < message.length && message[scanIndex] === currentSymbol) {
            repeatLength++;
            scanIndex++;
        }

        indexInMessage = scanIndex;
        if (repeatLength > 2) {
            res += (repeatLength);
            res += (currentSymbol);
        }
        else if (repeatLength === 2) {
            res += (currentSymbol);
            res += (currentSymbol);
        }
        else {
            res += (currentSymbol);
        }
    }
    return res;
}

    function encode(message) {
        var alph = [];
        for (var i = 0; i < offset; i++) {
            alph[i] = CONSTANTS.ALPHABET[(26 - offset) + i];
            //console.log(alph[i]);
        }
        for (var i = offset; i < 26; i++) {
            alph[i] = CONSTANTS.ALPHABET[i - offset];
            //console.log(alph[i]);
        }
        var encMess = '';
        for (var i = 0; i < message.length; i++) {
            if (!isNaN(message[i])) {
                encMess += message[i];
                //console.log(message[i]);
            }
            else {
                var index = CONSTANTS.ALPHABET.indexOf(message[i]);
                //console.log(message[i] + ' ' + index);
  
                //console.log(message[i] + ' ' + (message.charCodeAt(i)));
                //console.log(alph[CONSTANTS.ALPHABET.indexOf(message[i])] + ' ' + (alph[index].charCodeAt(0)));
                
                var toAppend = (message.charCodeAt(i)) ^ (alph[index].charCodeAt(0));
                encMess += toAppend;
            }
        }
        return encMess;
    }

    function sum(text) {
        var sum = 0;
        var n = text.length;

        for (var i = 0; i < n; i++) {
            if (!(parseInt(text[i]) % 2)) {
                sum += parseInt(text[i]);
            }
        }
        return sum;
    }

    function product(text) {
        var count = 0;

        for (var j = 0; j < text.length; j++) {
            if (((parseInt(text[j]) % 2) !== 0) || (isNaN(text[j]) % 2)) {
                count++;
            }
        }
        if (count = 0) {
            var product = 0;
        }
        else {
            var product = 1
        }
        for (var i = 0; i < text.length; i++) {
            if ((parseInt(text[i]) % 2)) {
                    product *= parseInt(text[i]);
                }
            }

            return product;
    }

    function allEven(text) {
        var count = 0;
        var n = text.length;

        for (var i = 0; i < n; i++) {
            if (!(parseInt(text[i]) % 2)) {
                count += 1;
            }
        }
        return count;
    }


    comprText = compress(text);
    encText = encode(comprText);
    //sumAndProduct(encText);
    //return encText;

    console.log( parseInt(sum(encText)));

    if ((allEven(encText) - encText.length) == 0){
        console.log(0);
    }
    else {
        console.log(parseInt(product(encText)));
    }
    
    //console.log(allEven(encText) - encText.length);
}


var test1 = [
    'aaaabbbccccaa',
    '0'
];
var test2 = [
    'aabbccmmnnvvzz',
    '0'
];


console.log(solve(test1));
console.log(solve(test2));
//console.log(solve(test3));