/// <reference path="../../../typings/jquery/jquery.d.ts"/>
function solve() {
    return function () {
        /* globals $ */

        /// <reference path="../typings/jquery/jquery.d.ts"/>

        $.fn.gallery = function (cols) {
            var $gallery = $(this);
            $gallery.addClass('gallery');
            $gallery.find('.selected').hide();

            var $images = $gallery.find('.image-container');
            for (var index = 1; index < $images.length + 1; index++) {
                var $currentImg = $images[index - 1];
                if (!((index - 1) % parseInt(cols || 4))) {
                    $currentImg.setAttribute('class', 'image-container clearfix');
                }
            }

            $('.image-container').on('click', function () {
                $('.selected').show();
                $('.gallery-list').addClass('blurred');
                var $newCurrentImageSrc;
                var $newNextImageSrc;
                var $newPreviosImageSrc;
                if ($(this).find('img').attr('src') == 'imgs/1.jpg') {
                    $newCurrentImageSrc = $(this).find('img').attr('src');
                    $newNextImageSrc = $(this).next().find('img').attr('src');
                    $newPreviosImageSrc = 'imgs/12.jpg';
                }
                else if ($(this).find('img').attr('src') == 'imgs/12.jpg') {
                    $newCurrentImageSrc = $(this).find('img').attr('src');
                    $newNextImageSrc = 'imgs/1.jpg';
                    $newPreviosImageSrc = $(this).prev().find('img').attr('src');
                }
                else {
                    $newCurrentImageSrc = $(this).find('img').attr('src');
                    $newNextImageSrc = $(this).next().find('img').attr('src');
                    $newPreviosImageSrc = $(this).prev().find('img').attr('src');
                }

                $('.selected').find('.current-image').find('img').attr('src', $newCurrentImageSrc);
                $('.selected').find('.next-image').find('img').attr('src', $newNextImageSrc);
                $('.selected').find('.previous-image').find('img').attr('src', $newPreviosImageSrc);
                
                $('.next-image').on('click', function () {
                if ($(this).find('img').attr('src') == 'imgs/1.jpg') {
                    $newCurrentImageSrc = $(this).find('img').attr('src');
                    $newNextImageSrc = $(this).next().find('img').attr('src');
                    $newPreviosImageSrc = 'imgs/12.jpg';
                }
                else if ($(this).find('img').attr('src') == 'imgs/12.jpg') {
                    $newCurrentImageSrc = $(this).find('img').attr('src');
                    $newNextImageSrc = 'imgs/1.jpg';
                    $newPreviosImageSrc = $(this).prev().find('img').attr('src');
                }
                else {
                    $newCurrentImageSrc = $(this).find('img').attr('src');
                    $newNextImageSrc = $(this).next().find('img').attr('src');
                    $newPreviosImageSrc = $(this).prev().find('img').attr('src');
                }

                $('.selected').find('.current-image').find('img').attr('src', $newCurrentImageSrc);
                $('.selected').find('.next-image').find('img').attr('src', $newNextImageSrc);
                $('.selected').find('.previous-image').find('img').attr('src', $newPreviosImageSrc);
            });
            });
            
            


            $('.current-image').on('click', function () {
                $('.selected').hide();
            });

        };
    };
}

module.exports = solve;