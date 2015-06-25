/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
	  * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * // method removeAttribute(attribute)
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');  

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {

    function isString(str) {
        return typeof str == "string" ||
		       (typeof str == "object" && str.constructor === String);
    }

    function validateType(value) {
        return value.length && isString(value) && /^[A-Z\d]+$/i.test(value);
    }

    function validateAttribute(value) {
        return value.length && isString(value) && /^[A-Z\d\-]+$/i.test(value);
    }

    function isEmptyObject(obj) {
        for (var prop in obj) {
            if (obj.hasOwnProperty(prop)) {
                return false;
            }
        }

        return true;
    }

    function parseHTML() {
        var output = '<' + this.type,
			keys = [],
			index,
			key,
			len;

        if (!isEmptyObject(this.attributes)) {
            for (key in this.attributes) {
                if (this.attributes.hasOwnProperty(key)) {
                    keys.push(key);
                }
            }

            keys.sort();
            len = keys.length;
            for (index = 0; index < len; index++) {
                output += ' ' + keys[index] + '="' + this.attributes[keys[index]] + '"';
            }
        }

        output += '>';

        if (this.children.length > 0) {
            len = this.children.length;
            for (index = 0; index < len; index++) {
                if (isString(this.children[index])) {
                    output += this.children[index];
                }
                else {
                    output += this.children[index].innerHTML;
                }
            }
        } else if (this.content) {
            output += this.content;
        }

        output += '</' + this.type + '>';

        return output;
    }

	var domElement = (function () {
	    var domElement = {

	        get type(){
	            return this._type;
	        },
	        set type(value){
	            this._type = value;
	        },
	        get content(){
	            return this._content;
	        },
	        set content(value) {
	            this._content = value;
	        },
	        get parent(){
	            return this._parent;
	        },
	        set parent(value) {
	            this._parent = value;
	        },
	        get children(){
	            return this._children;
	        },
	        set children(value) {
	            this._children = value;
	        },
	        get attributes(){
	            return this._attributes;
	        },
	        set attributes(value) {
	            this._attributes = value;
	        },

	        init: function (type) {
	            if (!validateType(type)) {
	                throw new Error('Invalid type');
	            }

	            this.type = type;
	            this.content = '';
	            this.parent;
	            this.children = [];
	            this.attributes = {};
	            this.innerHTML;

	            return this;
	        },

	        appendChild: function (child) {
	            child.parent = this;
	            this.children.push(child);

	            return this;
	        },

	        addAttribute: function (name, value) {
	            if (!validateAttribute(name)) {
	                throw new Error('Invalid attribute name');
	            }

	            this.attributes[name] = value;
	            
	            return this;
	        },

	        removeAttribute: function (attribute) {
	            if (!(validateAttribute(attribute) && this.attributes[attribute])) {
	                throw new Error('Invalid attribute!');
	            }

	            delete this.attributes[attribute];

	            return this;
	        },
	        get innerHTML() {
	            return parseHTML.call(this);
	        }
	    };
        
		return domElement;
	} ());
	return domElement;
}

module.exports = solve;
