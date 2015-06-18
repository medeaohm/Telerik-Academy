// Problem 7. Is prime
//
// Write an expression that checks if given positive integer number n (n ≤ 100) is prime.

var number = 37;

var result = 'Is ' + number + ' prime? -> ' + isPrime(number);
console.log(result);

function isPrime(number) {

    if (number < 2) return false;

    for (var div = 2; div <= Math.sqrt(number) ; div++) {
        if (!(number % div)) return false;
    }

    return true;
}