/// <reference path="../typings/jquery/jquery.d.ts"/>
/// <reference path="../typings/handlebars/handlebars.d.ts"/>

/*
##Task 3
* Create a jQuery plugin for ListView
  * Apply a template for each item of a collection
  * Using the data-template attribute set the ID of the template to use for the items
  * Must work with different collections and templates

  * _Example:_     
    * Having the HTML:        
                          
            <ul id="books-list" data-template="book-item-template"></ul>
            <script id="book-item-template" type="…">
              <li class="book-item">
                <a href="/#books/{{id}}">
                  <strong>{{title}}</strong>
                </a>
              </li>	
            </script>           
    
    * And executing:
    
             $('#books-list').listview(books);
                
    * Should generate:        
        
             <ul id="books-list" data-template="book-item-template">
              <li class="book-item">
                <a href="/#books/1">
                  <strong>JavaScript: The Good Parts</strong>
                </a>
              </li>
              <li class="book-item">
                <a href="/#books/2">
                  <strong>Secrets of the JavaScript Ninja</strong>
                </a>
              </li>
              <li class="book-item">
                <a href="/#books/3">
                  <strong>Core HTML5 Canvas</strong>
                </a>
              </li>
              <li class="book-item">
                <a href="/#books/4">
                  <strong>JavaScript Patterns</strong>
                </a>
              </li>
             </ul>
*/

function solve(){
  return function(){
    $.fn.listview = function(data){
      var template=$("#" + $(this).attr('data-template')).html(); 
      var compiledTemplate = handlebars.compile(template);
      
      for (var index = 0; index < data.length; index++) {        
        $(this).append(compiledTemplate(data[index]));  
      }
    };
  };
}

module.exports = solve;