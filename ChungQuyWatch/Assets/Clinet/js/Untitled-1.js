// JavaScript Document
$(document).ready(function() {

	$('#my_carousel5').owlCarousel({
		items: 3,
		loop:true,
		autoplay: true,
		autoplayTimeout: 3000,
		autoplayHoverPause: true,
		dots: false,
		nav:true,
		margin: 30,
					
	});
	$('#my_carousel').owlCarousel({
					items: 1,
					loop:true,
					autoplay: true,
					autoplayTimeout: 3000,
					autoplayHoverPause: true,
					dots: false,
					margin: 20
				});
				
				$('#my_carousel2,#my_carousel3,#my_carousel4,#my_carousel6,#my_carousel8').owlCarousel({
					items: 5,
					loop:true,
					autoplay: true,
					autoplayTimeout: 3000,
					autoplayHoverPause: true,
					dots: false,
					nav:true,
					margin: 30,
					
				});
				$('#my_carousel7').owlCarousel({
					items: 4,
					loop:true,
					autoplay: true,
					autoplayTimeout: 3000,
					autoplayHoverPause: true,
					dots: false,
					nav:true,
					
				});

				
              $('.play').on('click', function() {
                owl.trigger('play.owl.autoplay', [1000])
			  });
});