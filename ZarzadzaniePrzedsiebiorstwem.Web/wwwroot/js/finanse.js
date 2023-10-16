function addIndexEventListeners() {
    var indexA0 = document.getElementById("indexA0");
    var indexA1 = document.getElementById("indexA1");
    var indexA2 = document.getElementById("indexA2");
    var indexA3 = document.getElementById("indexA3");
    var indexA4 = document.getElementById("indexA4");

    function updateIndexA0() {
        var valueA0 = parseFloat(indexA0.value) || 0;
        var valueA1 = parseFloat(indexA1.value) || 0;
        var valueA2 = parseFloat(indexA2.value) || 0;
        var valueA3 = parseFloat(indexA3.value) || 0;
        var valueA4 = parseFloat(indexA4.value) || 0;

        if (!isNaN(valueA1) && !isNaN(valueA2) && !isNaN(valueA3) && !isNaN(valueA4)) {
            indexA0.value = (valueA1 + valueA2 + valueA3 + valueA4).toFixed(2);
            updateIndexC0();
        }
    }

    var indexB0 = document.getElementById("indexB0");
    var indexB1 = document.getElementById("indexB1");
    var indexB2 = document.getElementById("indexB2");
    var indexB3 = document.getElementById("indexB3");
    var indexB4 = document.getElementById("indexB4");
    var indexB5 = document.getElementById("indexB5");
    var indexB6 = document.getElementById("indexB6");
    var indexB7 = document.getElementById("indexB7");
    var indexB8 = document.getElementById("indexB8");

    function updateIndexB0() {
        var valueB0 = parseFloat(indexB0.value) || 0;
        var valueB1 = parseFloat(indexB1.value) || 0;
        var valueB2 = parseFloat(indexB2.value) || 0;
        var valueB3 = parseFloat(indexB3.value) || 0;
        var valueB4 = parseFloat(indexB4.value) || 0;
        var valueB5 = parseFloat(indexB5.value) || 0;
        var valueB6 = parseFloat(indexB6.value) || 0;
        var valueB7 = parseFloat(indexB7.value) || 0;
        var valueB8 = parseFloat(indexB8.value) || 0;

        if (!isNaN(valueB1) && !isNaN(valueB2) && !isNaN(valueB3) && !isNaN(valueB4) && !isNaN(valueB5) && !isNaN(valueB6) && !isNaN(valueB7) && !isNaN(valueB8)) {
            indexB0.value = (valueB1 + valueB2 + valueB3 + valueB4 + valueB5 + valueB6 + valueB7 + valueB8).toFixed(2);
            updateIndexC0();
        }

    }

    var indexC0 = document.getElementById("indexC0");

    function updateIndexC0() {
        var valueC0 = parseFloat(indexC0.value) || 0;

        var valueA0 = parseFloat(indexA0.value) || 0;
        var valueB0 = parseFloat(indexB0.value) || 0;

        if (!isNaN(valueA0) && !isNaN(valueB0)) {
            indexC0.value = (valueA0 - valueB0).toFixed(2);
            updateIndexF0();
        }
    }

    var indexD0 = document.getElementById("indexD0");
    var indexD1 = document.getElementById("indexD1");
    var indexD2 = document.getElementById("indexD2");
    var indexD3 = document.getElementById("indexD3");
    var indexD4 = document.getElementById("indexD4");

    function updateIndexD0() {
        var valueD0 = parseFloat(indexD0.value) || 0;
        var valueD1 = parseFloat(indexD1.value) || 0;
        var valueD2 = parseFloat(indexD2.value) || 0;
        var valueD3 = parseFloat(indexD3.value) || 0;
        var valueD4 = parseFloat(indexD4.value) || 0;

        if (!isNaN(valueD1) && !isNaN(valueD2) && !isNaN(valueD3) && !isNaN(valueD4)) {
            indexD0.value = (valueD1 + valueD2 + valueD3 + valueD4).toFixed(2);
            updateIndexF0();
        }
    }

    var indexE0 = document.getElementById("indexE0");
    var indexE1 = document.getElementById("indexE1");
    var indexE2 = document.getElementById("indexE2");
    var indexE3 = document.getElementById("indexE3");

    function updateIndexE0() {
        var valueE0 = parseFloat(indexE0.value) || 0;
        var valueE1 = parseFloat(indexE1.value) || 0;
        var valueE2 = parseFloat(indexE2.value) || 0;
        var valueE3 = parseFloat(indexE3.value) || 0;

        if (!isNaN(valueE1) && !isNaN(valueE2) && !isNaN(valueE3)) {
            indexE0.value = (valueE1 + valueE2 + valueE3).toFixed(2);
            updateIndexF0();
        }
    }

    var indexF0 = document.getElementById("indexF0");

    function updateIndexF0() {
        var valueF0 = parseFloat(indexF0.value) || 0;

        var valueC0 = parseFloat(indexC0.value) || 0;
        var valueD0 = parseFloat(indexD0.value) || 0;
        var valueE0 = parseFloat(indexE0.value) || 0;

        if (!isNaN(valueC0) && !isNaN(valueD0) && !isNaN(valueE0)) {
            indexF0.value = (valueC0 + valueD0 - valueE0).toFixed(2);
            updateIndexI0();
        }
    }

    var indexG0 = document.getElementById("indexG0");
    var indexG1 = document.getElementById("indexG1");
    var indexG2 = document.getElementById("indexG2");
    var indexG3 = document.getElementById("indexG3");
    var indexG4 = document.getElementById("indexG4");
    var indexG5 = document.getElementById("indexG5");

    function updateIndexG0() {
        var valueG0 = parseFloat(indexG0.value) || 0;
        var valueG1 = parseFloat(indexG1.value) || 0;
        var valueG2 = parseFloat(indexG2.value) || 0;
        var valueG3 = parseFloat(indexG3.value) || 0;
        var valueG4 = parseFloat(indexG4.value) || 0;
        var valueG5 = parseFloat(indexG5.value) || 0;

        if (!isNaN(valueG1) && !isNaN(valueG2) && !isNaN(valueG3) && !isNaN(valueG4) && !isNaN(valueG5)) {
            indexG0.value = (valueG1 + valueG2 + valueG3 + valueG4 + valueG5).toFixed(2);
            updateIndexI0();
        }
    }

    var indexH0 = document.getElementById("indexH0");
    var indexH1 = document.getElementById("indexH1");
    var indexH2 = document.getElementById("indexH2");
    var indexH3 = document.getElementById("indexH3");
    var indexH4 = document.getElementById("indexH4");

    function updateIndexH0() {
        var valueH0 = parseFloat(indexH0.value) || 0;
        var valueH1 = parseFloat(indexH1.value) || 0;
        var valueH2 = parseFloat(indexH2.value) || 0;
        var valueH3 = parseFloat(indexH3.value) || 0;
        var valueH4 = parseFloat(indexH4.value) || 0;

        if (!isNaN(valueH1) && !isNaN(valueH2) && !isNaN(valueH3) && !isNaN(valueH4)) {
            indexH0.value = (valueH1 + valueH2 + valueH3 + valueH4).toFixed(2);
            updateIndexI0();
        }
    }

    var indexI0 = document.getElementById("indexI0");

    function updateIndexI0() {
        var valueI0 = parseFloat(indexI0.value) || 0;

        var valueF0 = parseFloat(indexF0.value) || 0;
        var valueG0 = parseFloat(indexG0.value) || 0;
        var valueH0 = parseFloat(indexH0.value) || 0;

        if (!isNaN(valueF0) && !isNaN(valueG0) && !isNaN(valueH0)) {
            indexI0.value = (valueF0 + valueG0 - valueH0).toFixed(2);
            updateIndexL0();
        }
    }

    var indexJ0 = document.getElementById("indexJ0");

    function updateIndexJ0() {
        var valueI0 = parseFloat(indexI0.value) || 0;
        var valueJ0 = parseFloat(indexJ0.value) || 0;
        var valueK0 = parseFloat(indexK0.value) || 0;

        if (!isNaN(valueJ0) && !isNaN(valueI0) && !isNaN(valueK0)) {
            updateIndexL0();
        }
    }

    var indexK0 = document.getElementById("indexK0");

    function updateIndexK0() {
        var valueI0 = parseFloat(indexI0.value) || 0;
        var valueJ0 = parseFloat(indexJ0.value) || 0;
        var valueK0 = parseFloat(indexK0.value) || 0;

        if (!isNaN(valueJ0) && !isNaN(valueI0) && !isNaN(valueK0)) {
            updateIndexL0();
        }
    }


    var indexL0 = document.getElementById("indexL0");

    function updateIndexL0() {
        var valueL0 = parseFloat(indexL0.value) || 0;

        var valueI0 = parseFloat(indexI0.value) || 0;
        var valueJ0 = parseFloat(indexJ0.value) || 0;
        var valueK0 = parseFloat(indexK0.value) || 0;

        if (!isNaN(valueI0) && !isNaN(valueJ0) && !isNaN(valueK0)) {
            indexL0.value = (valueI0 - valueJ0 - valueK0).toFixed(2);
        }
    }


    indexA1.addEventListener("change", updateIndexA0);
    indexA2.addEventListener("change", updateIndexA0);
    indexA3.addEventListener("change", updateIndexA0);
    indexA4.addEventListener("change", updateIndexA0);

    indexB1.addEventListener("change", updateIndexB0);
    indexB2.addEventListener("change", updateIndexB0);
    indexB3.addEventListener("change", updateIndexB0);
    indexB4.addEventListener("change", updateIndexB0);
    indexB5.addEventListener("change", updateIndexB0);
    indexB6.addEventListener("change", updateIndexB0);
    indexB7.addEventListener("change", updateIndexB0);
    indexB8.addEventListener("change", updateIndexB0);

    indexD1.addEventListener("change", updateIndexD0);
    indexD2.addEventListener("change", updateIndexD0);
    indexD3.addEventListener("change", updateIndexD0);
    indexD4.addEventListener("change", updateIndexD0);

    indexE1.addEventListener("change", updateIndexE0);
    indexE2.addEventListener("change", updateIndexE0);
    indexE3.addEventListener("change", updateIndexE0);

    indexG1.addEventListener("change", updateIndexG0);
    indexG2.addEventListener("change", updateIndexG0);
    indexG3.addEventListener("change", updateIndexG0);
    indexG4.addEventListener("change", updateIndexG0);
    indexG5.addEventListener("change", updateIndexG0);

    indexH1.addEventListener("change", updateIndexH0);
    indexH2.addEventListener("change", updateIndexH0);
    indexH3.addEventListener("change", updateIndexH0);
    indexH4.addEventListener("change", updateIndexH0);

    indexI0.addEventListener("change", updateIndexI0);
    indexJ0.addEventListener("change", updateIndexJ0);
    indexK0.addEventListener("change", updateIndexK0);

}


function CreateDynamicForm() {
    var myButton = document.getElementById("submit");
    myButton.addEventListener("click", function () {

        var indexA0 = document.getElementById("indexA0");
        var valueA0 = parseFloat(indexA0.value) || null;

        var formData = new FormData();
        formData.append("RachunekZyskowIStrat.PrzychodyNettoZeSprzedazy", valueA0);

        fetch("/Finanse/DodajRachunekDoBazy", {
            method: "POST",
            body: formData
        })
        .then(response => response.json())
        .then(data => {
            console.log(data);
        })
        .catch(error => console.log(error));
    });
}


window.addEventListener('DOMContentLoaded', function() {
    addIndexEventListeners();
    CreateDynamicForm();
});