// Problem 5. Youngest person
//
// Write a function that finds the youngest person in a given array of people and prints his/hers full name
// Each person has properties firstname, lastname and age.

var people = [
  { fname : 'Gosho', lname: 'Petrov', age: 32 }, 
  { fname: 'Bay', lname: 'Ivan', age: 81 },
  { fname: 'Martin', lname: 'Ivanov', age: 15 }
];

function youngestPerson(array) {
    var youngest = 1000;
    var youngPerson;
    for (var i = 0; i < array.length; i++) {
        if (array[i].age < youngest) {
            youngest = array[i].age;
            youngPerson = array[i].fname + ' ' + array[i].lname;
        }
    }
    return youngPerson;
}

console.log(people);
console.log('The youngest person is: ' + youngestPerson(people));