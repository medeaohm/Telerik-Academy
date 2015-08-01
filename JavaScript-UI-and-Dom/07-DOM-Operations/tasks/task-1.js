/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (element, contents) {
  
  var domElement;
  
  if (typeof element != 'string' && !(element instanceof HTMLElement)) {
    throw new Error('Invalid Element');
  }
  
  if (typeof(element) === 'string') {
      domElement = document.getElementById(element)
  } 
  else {
      domElement = element;
  }
        
  if (!domElement) {
    throw new Error('DOM element with the provided ID does not exist');
  }
    
  if (!element || !contents) {
    throw new Error('Function params are missing');
  }
        
  for (var index = 0; index < contents.length; index++) {
    var contentsElement = contents[index];
    if (typeof contentsElement !== 'string' && typeof(contentsElement) !== 'number') {
      throw new Error('Any of the contents is neight `string` or `number`')
    }      
  }
    
    var firstChild = domElement.firstChild;
    while(domElement.firstChild){
      domElement.removeChild(firstChild);
      firstChild = firstChild.nextSibling;
    }
    
    var newDiv = document.createElement('div');
    var fragment = document.createDocumentFragment();
    var divToAdd;
    
    for(var index = 0; index < contents.length; index++){
      divToAdd = newDiv.cloneNode(true);
      divToAdd.innerHTML = contents[index];
      fragment.appendChild(divToAdd);
    }
    
    domElement.appendChild(fragment); 
  };
};