
    document.addEventListener("DOMContentLoaded", function () {
        var verticalPanel = document.querySelector(".vertical-panel");
        var navbar = document.querySelector(".hero-head");

        var isNavbarVisible = true;
        var lastScrollY = 0;

        window.addEventListener("scroll", function () {
            var scrollY = window.scrollY;

            if (scrollY > lastScrollY) {
                // Scroll w dół
                if (isNavbarVisible) {
                    verticalPanel.classList.toggle("vertical-panel-hidden", true);
                    isNavbarVisible = false;
                }
            } else {
                // Scroll w górę
                if (!isNavbarVisible && scrollY <= navbar.offsetHeight) {
                    verticalPanel.classList.toggle("vertical-panel-hidden", false);
                    isNavbarVisible = true;
                }
            }

            lastScrollY = scrollY;
        });
    });
