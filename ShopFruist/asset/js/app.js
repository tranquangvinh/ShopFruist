$(document).ready(function(){

    if ($('#sliderHome').length > 0) {
        $('#sliderHome').owlCarousel({
            items: 1,
            margin: 0
        })
    }

    if ($('#product-best-sale').length > 0) {
        $('#product-best-sale').owlCarousel({
            nav: true,
            responsive: {
                0 : {
                    items: 2
                },
                768: {
                    items: 3
                },
                992: {
                    items: 3
                }
            },
            margin: 15
        })
    }

    if ($('#listCustomer').length > 0) {
        $('#listCustomer').owlCarousel({
            margin: 30,
            dots: true,
            responsive: {
                0 : {
                    items: 1
                },
                600: {
                    items: 2
                },
                992: {
                    items: 3
                }
            }
        })
    }

    if ($('#owlPartner').length > 0) {
        $('#owlPartner').owlCarousel({
            margin: 30,
            nav: true,
            dots: false,
            navText: ['<span class="fa fa-angle-left"></span>', '<span class="fa fa-angle-right"></span>'],
            responsive: {
                0 : {
                    items: 3
                },
                600: {
                    items: 4
                },
                992: {
                    items: 6
                }
            }
        })
    }

    $('.headerSiteMobile').on('click', 'a', function (event) {
        var el = $(this);
        var li = el.closest('li');
        if (li.find('.sub-menu').length > 0) {
            event.preventDefault();
            $(li).toggleClass('active');
            $(li).children('.sub-menu').slideToggle();
            $(li).children('.overlayMenu').fadeToggle();
        }
    });

    $('.headerSiteMobile').on('click', '.btn-menu', function (event) {
        $('.overlayMenu').fadeToggle();
        $('.headerSiteMobile .menuMobile').toggleClass('active');
    });
    $('.headerSiteMobile').on('click', '.overlayMenu', function (event) {
        $('.overlayMenu').fadeToggle();
        $('.headerSiteMobile .menuMobile').removeClass('active');
    });

    $('.menuVertical').on('click', '.has-child > a', function (event) {
        event.preventDefault();
        $(this).closest('li').find('.sub-menu').slideToggle();
        $(this).toggleClass('active');
    });

    $('#backtotop').on('click', function (event) {
        event.preventDefault();
        $('body, html').animate({
            scrollTop: 0,
        }, 800)
    });
});


$(window).on('scroll', function () {
    if ($(window).scrollTop() > 0) {
        $('#backtotop').fadeIn()
    } else {
        $('#backtotop').fadeOut()
    }
});