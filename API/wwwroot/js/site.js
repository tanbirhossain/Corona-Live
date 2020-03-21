// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    NProgress.configure({ "color": ['#404E67'] });

    $(document).ajaxStart(function () {
        NProgress.start();
        //$(".has-spinner").buttonLoader('start');
    });



    $(document).ajaxComplete(function () {
        NProgress.done();
        //$(".has-spinner").buttonLoader('stop');
    });

    $(document).ajaxStop(function () {
        //$(".has-spinner").buttonLoader('stop');
    });

  



});


