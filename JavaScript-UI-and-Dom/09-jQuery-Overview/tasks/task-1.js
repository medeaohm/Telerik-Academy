/* globals $ */

/* 
Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
  return function (selector, count) {
    if (count <= 0) {
      throw new Error('Count should be > 0')
    }   
    if (count == undefined) {
      throw new Error('Count is undefiined')
    }   
    if (typeof count == 'object') {
      throw new Error();
    }
    if (!(/^\d+$/.test(count))) {
      throw new Error();
    }
    
    if (selector == null || selector == undefined) {
      throw new Error();
    }
    if (typeof selector != 'string') {
      throw new Error();
    }
    
   var $selectedItem = $(selector);
   var content = "List item #";
    
   $selectedItem.append("<ul class='items-list'/>");
   var $ul = $('.items-list');
   for (var index = 0; index < count; index++) {
     content += + index;
     $("<li class='list-item'>").html(content).appendTo($ul);
     console.log(content);
     content = "List item #";
   }
  };
};

module.exports = solve;