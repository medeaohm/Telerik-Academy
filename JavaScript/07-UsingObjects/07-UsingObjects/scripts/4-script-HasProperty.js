// Problem 4. Has property
//
// Write a function that checks if a given object contains a given property.

var person = {
    fname: 'Ivan',
    lname: 'Kostov',
    age: 25,
    occupation: 'Director'
};

console.log(person);
console.log('has occupation: ' + hasProperty(person, 'occupation'));
console.log('has gender: ' + hasProperty(person, 'gender'));
person.gender = 'male';
console.log(person);
console.log('has gender: ' + hasProperty(person, 'gender'));

function hasProperty(obj, prop) {
    return obj.hasOwnProperty(prop);
}