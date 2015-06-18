/*
 * Write a function that finds all the prime numbers in a range
 * It should return the prime numbers in an array
 * It must throw an Error if any of the range params is not convertible to Number
 * It must throw an Error if any of the range params is missing
 */

function primeNumbers(start, end) {
    if (start === undefined || end === undefined) {
        throw new Error();
    }
    else if (isNaN(parseInt(start)) || isNaN(parseInt(end))) {
        throw new Error();
    }
    else {
        var primes = [],
            n,
            maxDivisor,
            isPrime,
            i,
            start = +start,
            end = +end;

        for (n = start; n <= end; n += 1) {

            maxDivisor = Math.sqrt(n);
            isPrime = true;

            for ( i = 2; i <= maxDivisor; i++) {
                if (!(n % i)) {
                    isPrime = false;
                }
            }
            if (n === 1 || n === 0) {
                isPrime = false;
            }
            if (isPrime) {
                primes.push(n);
            }
        }
    }
    return primes;
}

console.log(primeNumbers(0, 6));