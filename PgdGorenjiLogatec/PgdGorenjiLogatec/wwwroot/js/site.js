/**
* Template Name: Company - v2.2.1
* Template URL: https://bootstrapmade.com/company-free-html-bootstrap-template/
* Author: BootstrapMade.com
* License: https://bootstrapmade.com/license/
*/

$(window).on('load', function () {
    var fullpath = window.location.pathname;
    console.log(fullpath)
    var filename = fullpath.replace(/^.*[\\\/]/, '');
    console.log(filename)
    if (fullpath == "/") {
        var currentLink = document.getElementById("Domov");
        currentLink.classList.add("active");
    }
    else {
        var currentLink = document.getElementById(filename);
        currentLink.classList.add("active");
    }
    
});


function Slika(id) {
    var el = document.getElementById("ewqewq").children;
    for (var i = 0; i < el.length; i++) {
        if (el[i].getAttribute("id") == id) {
            el[i].classList.add("active");
            continue;
        }
        else {
            if (el[i].getElementsByClassName('active')) {
                el[i].classList.remove("active");
            }
        }
    }
}