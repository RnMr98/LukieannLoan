$(document).ready(function () {

    var myIndex = 0;
    var i;
    var images = $(".images");
    slide();


    function slide() {
        for (i = 0; i < images.length; i++) {
            images[i].style.display = "none";
        }
        myIndex++;
        if (myIndex > images.length) { myIndex = 1 }
        images[myIndex - 1].style.display = "block";
        setTimeout(slide, 2000)
    }

})
