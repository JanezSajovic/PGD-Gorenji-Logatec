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
    console.log(id);
    var c = document.getElementById("carouselExampleControls").childNodes;
    var txt = "";
    var i;
    for (i = 0; i < c.length; i++) {
        console.log(c[i].nodeName)
    }
}