define(function(){
    'use strict';
    
    var menuButtons = $('.menubutton');
    
    //  User clicks on a different button on the LHS, possible change of content display.
    menuButtons.click(function () {

        console.log("this:", this);

        //  If the user clicked a button that isn't the current button.
        if (!$(this).hasClass('active')) {
            //  Clear content and show new content based on button clicked.
            menuButtons.removeClass('active');
            
            $(this).addClass('active');
            $('.content:visible').hide();
            $('#' + $(this).data('content')).show();
        }
    });
});