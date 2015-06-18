/*Problem 1. Make person
    Write a function for creating persons.
        Each person must have firstname, lastname, age and gender (true is female, false is male)
        Generate an array with ten person with different names, ages and genders
*/  
console.log('Problem 1:');
var people,
    pesho,
    kiro,
    petia,
    mitko,
    spiro,
    minka,
    kichka,
    blagoi,
    zahari,
    mima;

pesho = createPerson('Pesho', 'Ivanov', 28, false);
kiro = createPerson('Miro', 'Spirov', 13, false);
petia = createPerson('Petia', 'Ivanova', 23, true);
mitko = createPerson('mitko', 'Petrov', 38, false);
spiro = createPerson('Spiro', 'Mirov', 25, false);
minka = createPerson('Minka', 'Georgieva', 33, true);
kichka = createPerson('Kichka', 'Dragneva', 28, true);
blagoi = createPerson('Blagoi', 'Dimitrov', 23, false);
zahari = createPerson('Zahari', 'Minchev', 18, false);
mima = createPerson('Maria', 'Gincheva', 25, true);


people = [
    pesho,
    kiro,
    petia,
    mitko,
    spiro,
    minka,
    kichka,
    blagoi,
    zahari,
    mima
];


function createPerson(firstname, lastname, age, gender) {
    var person;
    person = {
        fname: firstname,
        lname: lastname,
        age: age,
        sex: gender
    };
    return person;
}
people.forEach(function (person) { console.log(person); });



/*Problem 2. People of age
    Write a function that checks if an array of person contains only people of age (with age 18 or greater)
        Use only array methods and no regular loops (for, while)
*/

console.log('Problem 2:');
console.log('Contains only people of age 18 or greater? -> ' + people.every(function (person) { return person.age >= 18; }));




/*Problem 3. Underage people
     Write a function that prints all underaged persons of an array of person
        Use Array#filter and Array#forEach
        Use only array methods and no regular loops (for, while)
*/ 

console.log('Problem 3:');
console.log('Underaged people: ');
people.filter(function (person) { return person.age < 18; })
    .forEach(function (person) { console.log(person); });





/*Problem 4. Average age of females
    Write a function that calculates the average age of all females, extracted from an array of persons
        Use Array#filter
        Use only array methods and no regular loops (for, while)
*/

console.log('Problem 4:');
var females = people.filter(function (person) { return person.sex; }),
    sum = females.reduce(function (sum, person) { return sum + person.age; }, 0),
    avg = sum / females.length;

console.log('Females: ');
females.forEach(function (person) { console.log(person); });
console.log('Average age: ' + avg);



/*Problem 5. Youngest person
     Write a function that finds the youngest male person in a given array of people and prints his full name
        Use only array methods and no regular loops (for, while)
        Use Array#find
*/

console.log('Problem 5:');
if (!Array.prototype.find) {
    Array.prototype.find = function (predicate) {
        if (this == null) {
            throw new TypeError('Array.prototype.find called on null or undefined');
        }
        if (typeof predicate !== 'function') {
            throw new TypeError('predicate must be a function');
        }
        var list = Object(this);
        var length = list.length >>> 0;
        var thisArg = arguments[1];
        var value;

        for (var i = 0; i < length; i++) {
            value = list[i];
            if (predicate.call(thisArg, value, i, list)) {
                return value;
            }
        }
        return undefined;
    };
}

function NameOfYoungestMale(people) {
    var youngestMale = people.sort(function (a, b) { return a.age - b.age; })
        .find(function (person) { return !person.sex; });

    return youngestMale.fname + ' ' + youngestMale.lname +
        '(' + youngestMale.age + ', ' + (youngestMale.sex ? 'F' : 'M') + ')';
}

console.log('Youngest male: ' + NameOfYoungestMale(people));



/*Problem 6. Group people
      Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
        Use Array#reduce
        Use only array methods and no regular loops (for, while)
*/

console.log('Problem 6:');
console.log('Groups by first letter of name: ');
var groups = people.reduce(function (gr, person) {
    var letter = person.fname[0];

    if (gr[letter]) {
        gr[letter].push(person);
    } else {
        gr[letter] = [person];
    }

    return gr;
}, {});

console.log(groups);