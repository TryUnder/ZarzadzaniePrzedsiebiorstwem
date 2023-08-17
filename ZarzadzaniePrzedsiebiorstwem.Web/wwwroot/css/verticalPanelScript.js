document.addEventListener("DOMContentLoaded", function () {
    var verticalPanel = document.querySelector(".vertical-panel");
    var navbar = document.querySelector(".hero-head");

    window.addEventListener("scroll", function () {
        //var offScreenNav = navbar.offsetHeight;
        var offScreenNav = navbar.offsetHeight/2;
        var scrollY = window.scrollY;

        if (scrollY >= offScreenNav) {
            verticalPanel.classList.toggle("vertical-panel-hidden", true);
        } else {
            verticalPanel.classList.toggle("vertical-panel-hidden", false);
        }
    });
});
