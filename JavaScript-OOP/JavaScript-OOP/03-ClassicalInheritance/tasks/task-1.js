/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullastname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
	var Person = (function () {
	    function Person(firstname, lastname, age) {
	        this.firstname = firstname;
	        this.lastname = lastname;
	        this.age = age;
	    }

	    Object.defineProperty(Person.prototype, 'firstname', {
	        get: function () {
	            return this._firstname;
	        },
	        set: function (first) {
	            if (!validateName(first)) {
	                throw new Error('Firstname is invalid');
	            }
	            this._firstname = first;
	        }
	    });

	    Object.defineProperty(Person.prototype, 'lastname', {
	        get: function () {
	            return this._lastname;
	        },
	        set: function (last) {
	            if (!validateName(last)) {
	                throw new Error('Lastname is invalid');
	            }
	            this._lastname = last;
	        }
	    });

	    Object.defineProperty(Person.prototype, 'fullname', {
	        get: function () {
	            return this.firstname + ' ' + this.lastname;
	        },
	        set: function (full) {
	            var names = full.split(' ');
	            this.firstname = names[0];
	            this.lastname = names[1];
	        }
	    });

	    Object.defineProperty(Person.prototype, 'age', {
	        get: function () {
	            return this._age;
	        },
	        set: function (value) {
	            if (!validateAge(value)) {
	                throw new Error('Age is invalid');
	            }
	            this._age = value;
	        }
	    });
        
	    Person.prototype.introduce = function () {
	        return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
	    }

	    function validateName(name) {
	        if (/^[A-Za-z]{3,20}$/.test(name)) {
	            return true;
	        }
	        return false;
	    }

	    function validateAge(age) {
	        if (!isNaN(parseInt(age))) {
	            if (age > 0 && age < 150) {
	                return true;
	            }
	            return false;
	        }
	        return false;
	    }

		return Person;
	} ());
	return Person;
}


module.exports = solve;