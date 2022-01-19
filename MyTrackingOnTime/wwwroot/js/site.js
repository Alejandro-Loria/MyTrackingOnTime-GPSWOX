// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//Enable popovers everywhere
var popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'))
var popoverList = popoverTriggerList.map(function (popoverTriggerEl) {
    return new bootstrap.Popover(popoverTriggerEl)
})

// Enable tooltips everywhere
var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'))
var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
    return new bootstrap.Tooltip(tooltipTriggerEl)
})

$('.selectAllcheckbox').click(function () {
    var a = this.checked;
    $('#collapseObjects :checkbox').prop('checked', a);
});

//$('.selectAllObjects').click(function () {
//    var c = this.checked;
//    $('.addObject :checkbox').prop('checked', c);
//});

$('.selectAllObjects').click(function (e) {
    $('input[type="checkbox"]', '.addObject').prop('checked', true);
    //$('#selectAllObjects').prop('disabled', true).removeClass("selectAllObjects").addClass("disabled");
    //$(this).hasClass('disabled');
});

$('.deselectAllObjects').click(function (e) {
    $('input[type="checkbox"]', '.addObject').prop('checked', false);
    //$('#selectAllObjects').prop('disabled', false).addClass("selectAllObjects");
    //$('#deselectAllObjects').prop('disabled', true).removeClass("deselectAllObjects");
});

$('.elementGroup').click(function () {
    var b = this.checked;
    $('.addObject ul > li :checkbox').prop('checked', b);
});

$('.addObject ul > li:nth-child(2) :checkbox').click(function () {
    var c = this.checked;
    if (c === false)
    $('.elementGroup').prop('checked', false);
});

$(function () {
    $('.checkAll').click(function () {
        if (this.checked) {
            $(".addObject .checkboxes").prop("checked", true);
        } else {
            $(".addObject .checkboxes").prop("checked", false);
        }
    });

    $(".checkboxes").click(function () {
        var numberOfCheckboxes = $(".checkboxes").length;
        var numberOfCheckboxesChecked = $('.checkboxes:checked').length;
        if (numberOfCheckboxes === numberOfCheckboxesChecked) {
            $(".checkAll").prop("checked", true);
        } else {
            $(".checkAll").prop("checked", false);
        }
    });
});

$(document).ready(function () {

    (function ($) {

        $('#inputSearch').keyup(function () {

            var rex = new RegExp($(this).val(), 'i');

            $('.addObject li').hide();

            $('.addObject li').filter(function () {
                return rex.test($(this).text());
            }).show();

        })

    }(jQuery));

});

//$(".selectAllObjects").on("click", function () {
//    $(".addObject ul").each(function () {
//        $(this).find("input").attr('checked', true, $(this).hasClass('disabled'));
//    });
//});