/// <reference path="../../typings/jquery/jquery.d.ts"/>

$.fn.tabs = function () {
	var $tabsControl = $(this);
	$tabsControl.addClass('tabs-container');
	setCurrent($tabsControl.find('.tab-item').first());
	
    $tabsControl.find('.tab-item-title').click(function () {
        setCurrent($(this).closest('.tab-item'));
    });
	
	function setCurrent($tabsItem) {
		$tabsControl.find('.tab-item').removeClass('current');
		$tabsControl.find('.tab-item-content').hide();
		$tabsItem.addClass('current').find('.tab-item-content').show();
	}	
};
