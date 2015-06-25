/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {

    /*
     * Titles do not start or end with spaces * Titles do not have consecutive spaces * Titles have at least one character
     */
    function invalidTitle(title) {
        if (title === '') {
            return true;
        }
        var len = title.length,
            i = 0,
            count = 0;
        if (title[0] === ' ') {
            return true;
        }
        if (title[len - 1] === ' ') {
            return true;
        }
        for (i = 1; i < len - 1; i++) {
            if (count === 2) {
                return true;
            }
            if (title[i] === ' ') {
                count += 1;
            }
            else if (title[i] !== ' ') {
                count = 0;
            }
        }
        return false;
    }

    /* 
     *  Names start with an upper case letter * All other symbols in the name (if any) are lowercase letters
     */  
    function validateName(name) {
        var firstLetter = name.substring(0, 1),
            rest = name.substr(1, name.length - 1);

        return (/^[A-Z]/.test(firstLetter) && ((/^[a-z]+$/.test(rest)) || !rest));
    }

    /*
     * 
     */
    function invalidPresentations(presentations) {
        if (typeof presentations === "undefined" || presentations === null || presentations.length < 1) {
            return true;
        }

        for (var i = 0; i < presentations.length; i += 1) {
            if (invalidTitle(presentations[i])) {
                return true;
            }
        }

        return false;
    }
    

    var students = [],
        studentID = 1;


    var Course = {
       /*
        *  Method init - * Accepts a string - course title * Accepts an array of strings - presentation titles 
        *  Throws if there is an invalid title * Titles do not start or end with spaces * Titles do not have consecutive spaces
        */
        init: function (title, presentations) {

            this.title = title;
            this.presentations = presentations;

            return this;
        },


        /*
         * method addStudent lists a student for the course * Accepts a string in the format 'Firstname Lastname'
         * Throws if any of the names are not valid * Generates a unique student ID and returns it
         */
        addStudent: function (name) {

            var names = name.split(' '),
                firstname = names[0],
                lastname = names[1],
                rest = names[2];

            if (names.length !== 2) {
                throw new Error();
            }

            if (!validateName(firstname)) {
                throw new Error('Firstname is invalid');
            }

            if (!validateName(lastname)) {
                throw new Error('Lastname is invalid');
            }

            students.push({
                firstname: firstname,
                lastname: lastname,
                ID : studentID
                });

            return studentID++;
            
        },


        /*
         * method getAllStudents that returns an array of students in the format: {firstname: 'string', lastname: 'string', id: StudentID}
         */
        getAllStudents: function () {
            return students.slice(0);
        },

        /*
        * Accepts studentID and homeworkID * homeworkID 1 is for the first presentation * homeworkID 2 is for the second one ...
        * Throws if any of the IDs are invalid
        */         
        submitHomework: function (studentID, homeworkID) {
            if (studentID <= 0 || studentID % 1 !== 0 || studentID > students.length) {
                throw new Error("Invalid Student ID");
            }
            if (homeworkID <= 0 || homeworkID % 1 !== 0 || homeworkID > this.presentations.length) {
                throw new Error("Invalid Homework ID");
            }
        },


       /*
        * method pushExamResults* Accepts an array of items in the format {StudentID: ..., Score: ...}
        * StudentIDs which are not listed get 0 points
        * Throw if there is an invalid StudentID
        * Throw if same StudentID is given more than once ( he tried to cheat (: )
        * Throw if Score is not a number 
        */
        pushExamResults: function(results) {
        },


        /*
         * method getTopStudents returns an array of the top 10 performing students * Array must be sorted from best to worst
         * If there are less than 10, return them all * The final score that is used to calculate the top performing students is done as follows:
         * 75% of the exam result
         * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
         */
        getTopStudents: function() {
        }
    };

    Object.defineProperty(Course, 'title', {
        get: function () {
            return Course._title;
        },
        set: function (title) {
            if (invalidTitle(title)) {
                throw new Error('Invalid title.');
            }

            Course._title = title;
        }
    });

    Object.defineProperty(Course, 'presentations', {
        get: function () {
            return Course._presentations;
        },
        set: function (presentations) {
            
            if (invalidPresentations(presentations)) {
                throw new Error('Invalid presentations.');
            }
            Course._presentations = presentations;
        }
    });



    return Course;
}

//var test = solve();
//var testCourse = test.init('Course title', ['p1', 'p2', 'p3']);

//console.log(testCourse.title);
//console.log(testCourse.presentations);
//test.addStudent('Ivan Ivanov');
//test.addStudent('Niya Omerska');
//console.log(test.getAllStudents());

module.exports = solve;


