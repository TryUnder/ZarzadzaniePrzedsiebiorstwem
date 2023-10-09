document.addEventListener('DOMContentLoaded', function () {
    const slider = document.querySelector('.slider');
    const leftArrow = document.querySelector(".left-arrow");
    const rightArrow = document.querySelector(".right-arrow");
    let autoSlideInterval; // Store the interval ID for automatic slide transitions

    // Function to switch to the next slide
    function nextSlide() {
        // Find all radio inputs
        const radioInputs = document.querySelectorAll('input[name="button"]');
        // Find the currently checked radio input
        const currentRadio = document.querySelector('input[name="button"]:checked');

        // Find the index of the currently checked radio input
        const currentIndex = Array.from(radioInputs).indexOf(currentRadio);

        // Calculate the index of the next radio input
        const nextIndex = (currentIndex + 1) % radioInputs.length;

        // Check the next radio input to switch to the next slide
        radioInputs[nextIndex].checked = true;

        // If the next slide is the first slide, reset to the first slide immediately
        if (nextIndex === 0) {
            radioInputs[0].checked = true;
        }
    }





    // Automatyczna zmiana slajdu
    function startAutoSlide() {
        autoSlideInterval = setInterval(nextSlide, 10000);
    }

    //Wywołanie funkcji
    startAutoSlide();

    // Function to handle keyboard arrow key presses
    function handleKeyPress(event) {
        if (event.keyCode === 37) {
            // Left arrow key (37) pressed
            clearInterval(autoSlideInterval); // Stop automatic slide transitions
            // Manually go to the previous slide
            const currentRadio = document.querySelector('input[name="button"]:checked');
            const previousRadio = currentRadio.previousElementSibling || document.querySelector('input[name="button"]:last-child');
            previousRadio.checked = true;
            startAutoSlide(); // Restart automatic slide transitions
        } else if (event.keyCode === 39) {
            // Right arrow key (39) pressed
            clearInterval(autoSlideInterval); // Stop automatic slide transitions
            // Manually go to the next slide
            nextSlide();
            startAutoSlide(); // Restart automatic slide transitions
        }
    }

    // Add event listeners for arrow key presses
    document.addEventListener('keydown', handleKeyPress);

    // Add click event listeners for on-screen arrows
    leftArrow.addEventListener('click', function () {
        clearInterval(autoSlideInterval); // Stop automatic slide transitions
        // Manually go to the previous slide
        const currentRadio = document.querySelector('input[name="button"]:checked');
        const previousRadio = currentRadio.previousElementSibling || document.querySelector('input[name="button"]:last-child');
        previousRadio.checked = true;
        startAutoSlide(); // Restart automatic slide transitions
    });

    rightArrow.addEventListener('click', function () {
        clearInterval(autoSlideInterval); // Stop automatic slide transitions
        // Manually go to the next slide
        nextSlide();
        startAutoSlide(); // Restart automatic slide transitions
    });
});

