// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    const URL = 'https://localhost:7171/home/fetchData';
    $.ajax({
        url: URL,
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            if (data !== undefined) {
                const name = data.name;
                const description = data.description;
                $('.right-side-content-data .right-side-content-data-name').text(name);
                $('.right-side-content-data .right-side-content-data-desc').text(description);
            }
        },
        error: function (error) {
            console.log('Error:', error);
        }
    });
});
