// Problem 6. Group array
//
// Write a function that groups an array of people by age, first or last name.
// The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
// Use function overloading (i.e. just one function)

function Person(fname, lname, age) {
    this.fname = fname;
    this.lname = lname;
    this.age = age;
}

Person.prototype.toString = function () {
    return '(' + this.fname + ' ' + this.lname + ',' + this.age + ')';
};

var people = [
    new Person('Ivan', 'Kostov', 24),
    new Person('Mitko', 'Hristov', 25),
    new Person('Mitko', 'Kostov', 30),
    new Person('Ivan', 'Kenov', 25),
    new Person('Hristo', 'Kenov', 25),
    new Person('Ivan', 'Hristov', 30),
    new Person('Hristo', 'Hristov', 30),
    new Person('Ivan', 'Kostov', 24),
    new Person('Mitko', 'Hristov', 24)
];

function group(arr, prop) {
    var group = [];

    for (var ind in arr) {
        var currProp = arr[ind][prop];
        group[currProp] = group[currProp] || [];
        group[currProp].push(arr[ind]);
    }

    return group;
}

function printGroups(prop, arr) {
    console.log(prop);
    for (var key in arr) {
        console.log(arr[key].join('; '));
    }
    console.log();
}

var props = ['fname', 'lname', 'age'];

for (var ind in props) {
    var groups = group(people, props[ind]);
    printGroups(props[ind], groups);
}