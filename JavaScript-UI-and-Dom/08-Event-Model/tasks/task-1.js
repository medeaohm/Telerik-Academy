/* globals $ */

/* 

Create a function that takes an id or DOM element and:
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
  
*/

function solve(){
  return function (element) {
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
    
    if (domElement == null || domElement == undefined) {
      throw new Error('Selector does not select nothing');
    }
    
    var buttons = document.getElementsByClassName('button');
		for (var i = 0, len = buttons.length; i < len; i++) {
			buttons[i].innerHTML = 'hide';
		}

		for (i = 0, len = buttons.length; i < len; i++) {
			var currButton = buttons[i];

			currButton.addEventListener('click', function(ev) {
				var clickedButton = ev.target;
				var nextContent = clickedButton.nextElementSibling;
				while (nextContent && nextContent.className.indexOf('content') < 0) {
					nextContent = nextContent.nextElementSibling;
				}

				var isContentVisible = nextContent.style.display === '';
				if (isContentVisible) {
					nextContent.style.display = 'none';
					clickedButton.innerHTML = 'show';
				} else {
					nextContent.style.display = ''; 
					clickedButton.innerHTML = 'hide';
				}
			});
		}
  };
};

module.exports = solve;