/// <reference path="../typings/jquery/jquery.d.ts"/>

function solve(){
  return function(selector){
    $(selector)
        .wrap('<div class="dropdown-list"></div>')
        .css('display',' none');
      
   $('.dropdown-list')
        .append('<div class="current"></div>');

   $('.current')
        .attr('data-value','')
        .html('Option 1');

        
   $('.dropdown-list')
        .append('<div class="options-container" style="display: none; position: absolute"></div>');
   
   $('select')
        .children()
        .each(function(index, item) {
				      $('<div class="dropdown-item"></div>')
                  .attr({
                    'data-value': $('option').val(), 
                    'data-index' : index.toString()
                    })
                    .appendTo($('.options-container'))
                    .html('Option ' + index,toString());
			      });
        
   
   
   $('.current').on('click', function() {
        var $this = $(this);
        $('.options-container').show();
        $this.html('Select a value');
   }); 
   
   $('.dropdown-item').on('click', function() {
        var $this = $(this);
       $('.current').val($this.html()).attr('data-value',$('select').val()).html($this.html());
       $('.current').val($this.val());
       $('.options-container').val($('select').attr('data-value')).hide();
   });   
  };
}

module.exports = solve;