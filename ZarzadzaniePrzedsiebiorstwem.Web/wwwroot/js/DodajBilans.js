function addIndexEventListeners() {

    // aktywa

    var indexAA0 = document.getElementById("indexAA0");
    var indexAA1 = document.getElementById("indexAA1");

    var indexAA2 = document.getElementById("indexAA2");

    var indexAA3 = document.getElementById("indexAA3");
    var indexAA4 = document.getElementById("indexAA4");
    var indexAA5 = document.getElementById("indexAA5");
    var indexAA6 = document.getElementById("indexAA6");
    var indexAA7 = document.getElementById("indexAA7");
    var indexAA8 = document.getElementById("indexAA8");

    function updateIndexAA0() {
        //AA2 nie moze brac pod uwage, bo i tak suma się robi z cząstkowych sum do aktywow trwalych
        var valueAA0 = parseFloat(indexAA0.value) || 0;
        var valueAA1 = parseFloat(indexAA1.value) || 0;
        var valueAA3 = parseFloat(indexAA3.value) || 0;
        var valueAA4 = parseFloat(indexAA4.value) || 0;
        var valueAA5 = parseFloat(indexAA5.value) || 0;
        var valueAA6 = parseFloat(indexAA6.value) || 0;
        var valueAA7 = parseFloat(indexAA7.value) || 0;
        var valueAA8 = parseFloat(indexAA8.value) || 0;


        if (!isNaN(valueAA1) && !isNaN(valueAA3) && !isNaN(valueAA4) && !isNaN(valueAA5) && !isNaN(valueAA6) && !isNaN(valueAA7) && !isNaN(valueAA8)) {
            indexAA0.value = (valueAA1 + valueAA3 + valueAA4 + valueAA5 + valueAA6 + valueAA7 + valueAA8).toFixed(2);
            updateIndexAE0();
        }
    }

    function updateIndexAA2() {
        var valueAA2 = parseFloat(indexAA2.value) || 0;
        var valueAA3 = parseFloat(indexAA3.value) || 0;
        var valueAA4 = parseFloat(indexAA4.value) || 0;
        var valueAA5 = parseFloat(indexAA5.value) || 0;

        if (!isNaN(valueAA3) && !isNaN(valueAA4) && !isNaN(valueAA5)) {
            indexAA2.value = (valueAA3 + valueAA4 + valueAA5).toFixed(2);
        }
    }

    var indexAB0 = document.getElementById("indexAB0");
    var indexAB1 = document.getElementById("indexAB1");
    var indexAB2 = document.getElementById("indexAB2");
    var indexAB3 = document.getElementById("indexAB3");
    var indexAB4 = document.getElementById("indexAB4");
    var indexAB5 = document.getElementById("indexAB5");
    var indexAB6 = document.getElementById("indexAB6");
    var indexAB7 = document.getElementById("indexAB7");
    var indexAB8 = document.getElementById("indexAB8");
    var indexAB9 = document.getElementById("indexAB9");
    var indexAB10 = document.getElementById("indexAB10");
    var indexAB11 = document.getElementById("indexAB11");
    var indexAB12 = document.getElementById("indexAB12");
    var indexAB13 = document.getElementById("indexAB13");
    var indexAB14 = document.getElementById("indexAB14");
    var indexAB15 = document.getElementById("indexAB15");

    function updateIndexAB0() {
        var valueAB0 = parseFloat(indexAB0.value) || 0;
        //var valueAB1 = parseFloat(indexAB1.value) || 0;
        var valueAB2 = parseFloat(indexAB2.value) || 0;
        var valueAB3 = parseFloat(indexAB3.value) || 0;
        var valueAB4 = parseFloat(indexAB4.value) || 0;
        var valueAB5 = parseFloat(indexAB5.value) || 0;
        var valueAB6 = parseFloat(indexAB6.value) || 0;
        //var valueAB7 = parseFloat(indexAB7.value) || 0;
        var valueAB8 = parseFloat(indexAB8.value) || 0;
        var valueAB9 = parseFloat(indexAB9.value) || 0;
        var valueAB10 = parseFloat(indexAB10.value) || 0;
        var valueAB11 = parseFloat(indexAB11.value) || 0;
        //var valueAB12 = parseFloat(indexAB12.value) || 0;
        var valueAB13 = parseFloat(indexAB13.value) || 0;
        var valueAB14 = parseFloat(indexAB14.value) || 0;
        var valueAB15 = parseFloat(indexAB15.value) || 0;

        if (!isNaN(valueAB2) && !isNaN(valueAB3) && !isNaN(valueAB4) && !isNaN(valueAB5) && !isNaN(valueAB6) && !isNaN(valueAB8) && !isNaN(valueAB9) && !isNaN(valueAB10) && !isNaN(valueAB11) && !isNaN(valueAB13) && !isNaN(valueAB14) && !isNaN(valueAB15)) {
            indexAB0.value = (valueAB2 + valueAB3 + valueAB4 + valueAB5 + valueAB6 + valueAB8 + valueAB9 + valueAB10 + valueAB11 + valueAB13 + valueAB14 + valueAB15).toFixed(2);
            updateIndexAE0();
        }
    }

    function updateIndexAB1() {
        var valueAB1 = parseFloat(indexAB1.value) || 0;
        var valueAB2 = parseFloat(indexAB2.value) || 0;
        var valueAB3 = parseFloat(indexAB3.value) || 0;
        var valueAB4 = parseFloat(indexAB4.value) || 0;
        var valueAB5 = parseFloat(indexAB5.value) || 0;
        var valueAB6 = parseFloat(indexAB6.value) || 0;

        if (!isNaN(valueAB2) && !isNaN(valueAB3) && !isNaN(valueAB4) && !isNaN(valueAB5) && !isNaN(valueAB6)) {
            indexAB1.value = (valueAB2 + valueAB3 + valueAB4 + valueAB5 + valueAB6).toFixed(2);
        }
    }

    function updateIndexAB7() {
        var valueAB7 = parseFloat(indexAB7.value) || 0;
        var valueAB8 = parseFloat(indexAB8.value) || 0;
        var valueAB9 = parseFloat(indexAB9.value) || 0;
        var valueAB10 = parseFloat(indexAB10.value) || 0;
        var valueAB11 = parseFloat(indexAB11.value) || 0;

        if (!isNaN(valueAB8) && !isNaN(valueAB9) && !isNaN(valueAB10) && !isNaN(valueAB11)) {
            indexAB7.value = (valueAB8 + valueAB9 + valueAB10 + valueAB11).toFixed(2);
        }
    }

    function updateIndexAB12() {
        var valueAB12 = parseFloat(indexAB12.value) || 0;
        var valueAB13 = parseFloat(indexAB13.value) || 0;
        var valueAB14 = parseFloat(indexAB14.value) || 0;

        if (!isNaN(valueAB13) && !isNaN(valueAB14)) {
            indexAB12.value = (valueAB13 + valueAB14).toFixed(2);
        }
    }

    var valueAC0 = document.getElementById("indexAC0");
    var valueAD0 = document.getElementById("indexAD0");
    var valueAE0 = document.getElementById("indexAE0");

    function updateIndexAE0() {
        var valueAA0 = parseFloat(indexAA0.value) || 0;
        var valueAB0 = parseFloat(indexAB0.value) || 0;
        var valueAC0 = parseFloat(indexAC0.value) || 0;
        var valueAD0 = parseFloat(indexAD0.value) || 0;

        if (!isNaN(valueAA0) && !isNaN(valueAB0) && !isNaN(valueAC0) && !isNaN(valueAD0)) {
            valueAE0.value = (valueAA0 + valueAB0 + valueAC0 + valueAD0).toFixed(2);
        }
    }

    indexAA1.addEventListener("change", updateIndexAA0);
    indexAA2.addEventListener("change", updateIndexAA0);
    indexAA3.addEventListener("change", updateIndexAA0);
    indexAA4.addEventListener("change", updateIndexAA0);
    indexAA5.addEventListener("change", updateIndexAA0);
    indexAA6.addEventListener("change", updateIndexAA0);
    indexAA7.addEventListener("change", updateIndexAA0);
    indexAA8.addEventListener("change", updateIndexAA0);

    indexAA3.addEventListener("change", updateIndexAA2);
    indexAA4.addEventListener("change", updateIndexAA2);
    indexAA5.addEventListener("change", updateIndexAA2);

    //indexAB1.addEventListener("change", updateIndexAB0);
    indexAB2.addEventListener("change", updateIndexAB0);
    indexAB3.addEventListener("change", updateIndexAB0);
    indexAB4.addEventListener("change", updateIndexAB0);
    indexAB5.addEventListener("change", updateIndexAB0);
    indexAB6.addEventListener("change", updateIndexAB0);
    //indexAB7.addEventListener("change", updateIndexAB0);
    indexAB8.addEventListener("change", updateIndexAB0);
    indexAB9.addEventListener("change", updateIndexAB0);
    indexAB10.addEventListener("change", updateIndexAB0);
    indexAB11.addEventListener("change", updateIndexAB0);
    //indexAB12.addEventListener("change", updateIndexAB0);
    indexAB13.addEventListener("change", updateIndexAB0);
    indexAB14.addEventListener("change", updateIndexAB0);
    indexAB15.addEventListener("change", updateIndexAB0);

    indexAB2.addEventListener("change", updateIndexAB1);
    indexAB3.addEventListener("change", updateIndexAB1);
    indexAB4.addEventListener("change", updateIndexAB1);
    indexAB5.addEventListener("change", updateIndexAB1);
    indexAB6.addEventListener("change", updateIndexAB1);

    indexAB8.addEventListener("change", updateIndexAB7);
    indexAB9.addEventListener("change", updateIndexAB7);
    indexAB10.addEventListener("change", updateIndexAB7);
    indexAB11.addEventListener("change", updateIndexAB7);

    indexAB13.addEventListener("change", updateIndexAB12);
    indexAB14.addEventListener("change", updateIndexAB12);

    indexAC0.addEventListener("change", updateIndexAE0);
    indexAD0.addEventListener("change", updateIndexAE0);


    //// pasywa

    var indexPA0 = document.getElementById("indexPA0");
    var indexPA1 = document.getElementById("indexPA1");
    var indexPA2 = document.getElementById("indexPA2");
    var indexPA3 = document.getElementById("indexPA3");
    var indexPA4 = document.getElementById("indexPA4");
    var indexPA5 = document.getElementById("indexPA5");

    function updatePA0() {
        var valuePA0 = parseFloat(indexPA0.value) || 0;
        var valuePA1 = parseFloat(indexPA1.value) || 0;
        var valuePA2 = parseFloat(indexPA2.value) || 0;
        var valuePA3 = parseFloat(indexPA3.value) || 0;
        var valuePA4 = parseFloat(indexPA4.value) || 0;
        var valuePA5 = parseFloat(indexPA5.value) || 0;

        if (!isNaN(valuePA1) && !isNaN(valuePA2) && !isNaN(valuePA3) && !isNaN(valuePA4) && !isNaN(valuePA5)) {
            indexPA0.value = (valuePA1 + valuePA2 + valuePA3 + valuePA4 + valuePA5).toFixed(2);
            updateIndexPE0();
        }
    }

    var indexPB0 = document.getElementById("indexPB0");
    var indexPB1 = document.getElementById("indexPB1");
    var indexPB2 = document.getElementById("indexPB2");
    var indexPB3 = document.getElementById("indexPB3");
    var indexPB4 = document.getElementById("indexPB4");
    var indexPB5 = document.getElementById("indexPB5");
    var indexPB6 = document.getElementById("indexPB6");
    var indexPB7 = document.getElementById("indexPB7");
    var indexPB8 = document.getElementById("indexPB8");
    var indexPB9 = document.getElementById("indexPB9");
    var indexPB10 = document.getElementById("indexPB10");
    var indexPB11 = document.getElementById("indexPB11");
    var indexPB12 = document.getElementById("indexPB12");

    function updateIndexPB0() {
        var valuePB0 = parseFloat(indexPB0.value) || 0;
        var valuePB1 = parseFloat(indexPB1.value) || 0;
        var valuePB3 = parseFloat(indexPB3.value) || 0;
        var valuePB5 = parseFloat(indexPB5.value) || 0;
        var valuePB6 = parseFloat(indexPB6.value) || 0;
        var valuePB7 = parseFloat(indexPB7.value) || 0;
        var valuePB8 = parseFloat(indexPB8.value) || 0;
        var valuePB9 = parseFloat(indexPB9.value) || 0;
        var valuePB10 = parseFloat(indexPB10.value) || 0;
        var valuePB11 = parseFloat(indexPB11.value) || 0;
        var valuePB12 = parseFloat(indexPB12.value) || 0;

        if (!isNaN(valuePB1) && !isNaN(valuePB3) && !isNaN(valuePB5) && !isNaN(valuePB6) && !isNaN(valuePB7) && !isNaN(valuePB8) && !isNaN(valuePB9) && !isNaN(valuePB10) && !isNaN(valuePB11) && !isNaN(valuePB12)) {
            indexPB0.value = (valuePB1 + valuePB3 + valuePB5 + valuePB6 + valuePB7 + valuePB8 + valuePB9 + valuePB10 + valuePB11 + valuePB12).toFixed(2);
            updateIndexPE0();
        }
    }

    function updateIndexPB2() {
        var valuePB2 = parseFloat(indexPB2.value) || 0;
        var valuePB3 = parseFloat(indexPB3.value) || 0;

        if (!isNaN(valuePB3)) {
            indexPB2.value = (valuePB3).toFixed(2);
        }
    }

    function updateIndexPB4() {
        var valuePB4 = parseFloat(indexPB4.value) || 0;
        var valuePB5 = parseFloat(indexPB5.value) || 0;
        var valuePB6 = parseFloat(indexPB6.value) || 0;
        var valuePB7 = parseFloat(indexPB7.value) || 0;
        var valuePB8 = parseFloat(indexPB8.value) || 0;
        var valuePB9 = parseFloat(indexPB9.value) || 0;
        var valuePB10 = parseFloat(indexPB10.value) || 0;
        var valuePB11 = parseFloat(indexPB11.value) || 0;

        if (!isNaN(valuePB5) && !isNaN(valuePB6) && !isNaN(valuePB7) && !isNaN(valuePB8) && !isNaN(valuePB9) && !isNaN(valuePB10) && !isNaN(valuePB11)) {
            indexPB4.value = (valuePB5 + valuePB6 + valuePB7 + valuePB8 + valuePB9 + valuePB10 + valuePB11).toFixed(2);
        }
    }

    function updateIndexPE0() {
        var valuePA0 = parseFloat(indexPA0.value) || 0;
        var valuePB0 = parseFloat(indexPB0.value) || 0;

        if (!isNaN(valuePA0) && !isNaN(valuePB0)) {
            indexPE0.value = (valuePA0 + valuePB0).toFixed(2);
        }
    }

    indexPA1.addEventListener("change", updatePA0);
    indexPA2.addEventListener("change", updatePA0);
    indexPA3.addEventListener("change", updatePA0);
    indexPA4.addEventListener("change", updatePA0);
    indexPA5.addEventListener("change", updatePA0);

    indexPB1.addEventListener("change", updateIndexPB0);
    indexPB3.addEventListener("change", updateIndexPB0);
    indexPB5.addEventListener("change", updateIndexPB0);
    indexPB6.addEventListener("change", updateIndexPB0);
    indexPB7.addEventListener("change", updateIndexPB0);
    indexPB8.addEventListener("change", updateIndexPB0);
    indexPB9.addEventListener("change", updateIndexPB0);
    indexPB10.addEventListener("change", updateIndexPB0);
    indexPB11.addEventListener("change", updateIndexPB0);
    indexPB12.addEventListener("change", updateIndexPB0);

    indexPB3.addEventListener("change", updateIndexPB2);

    indexPB5.addEventListener("change", updateIndexPB4);
    indexPB6.addEventListener("change", updateIndexPB4);
    indexPB7.addEventListener("change", updateIndexPB4);
    indexPB8.addEventListener("change", updateIndexPB4);
    indexPB9.addEventListener("change", updateIndexPB4);
    indexPB10.addEventListener("change", updateIndexPB4);
    indexPB11.addEventListener("change", updateIndexPB4);


}

function CreateFormData() {
    var formData = new FormData();

    var OkresSprawozdawczy = document.getElementById("OkresSprawozdawczy");

    var indexAA0 = document.getElementById("indexAA0");
    var indexAA1 = document.getElementById("indexAA1");
    var indexAA2 = document.getElementById("indexAA2");
    var indexAA3 = document.getElementById("indexAA3");
    var indexAA4 = document.getElementById("indexAA4");
    var indexAA5 = document.getElementById("indexAA5");
    var indexAA6 = document.getElementById("indexAA6");
    var indexAA7 = document.getElementById("indexAA7");
    var indexAA8 = document.getElementById("indexAA8");

    var valueAA0 = parseFloat(indexAA0.value) || 0;
    var valueAA1 = parseFloat(indexAA1.value) || 0;
    var valueAA2 = parseFloat(indexAA2.value) || 0;
    var valueAA3 = parseFloat(indexAA3.value) || 0;
    var valueAA4 = parseFloat(indexAA4.value) || 0;
    var valueAA5 = parseFloat(indexAA5.value) || 0;
    var valueAA6 = parseFloat(indexAA6.value) || 0;
    var valueAA7 = parseFloat(indexAA7.value) || 0;
    var valueAA8 = parseFloat(indexAA8.value) || 0;

    var indexAB0 = document.getElementById("indexAB0");
    var indexAB1 = document.getElementById("indexAB1");
    var indexAB2 = document.getElementById("indexAB2");
    var indexAB3 = document.getElementById("indexAB3");
    var indexAB4 = document.getElementById("indexAB4");
    var indexAB5 = document.getElementById("indexAB5");
    var indexAB6 = document.getElementById("indexAB6");
    var indexAB7 = document.getElementById("indexAB7");
    var indexAB8 = document.getElementById("indexAB8");
    var indexAB9 = document.getElementById("indexAB9");
    var indexAB10 = document.getElementById("indexAB10");
    var indexAB11 = document.getElementById("indexAB11");
    var indexAB12 = document.getElementById("indexAB12");
    var indexAB13 = document.getElementById("indexAB13");
    var indexAB14 = document.getElementById("indexAB14");
    var indexAB15 = document.getElementById("indexAB15");

    var valueAB0 = parseFloat(indexAB0.value) || 0;
    var valueAB1 = parseFloat(indexAB1.value) || 0;
    var valueAB2 = parseFloat(indexAB2.value) || 0;
    var valueAB3 = parseFloat(indexAB3.value) || 0;
    var valueAB4 = parseFloat(indexAB4.value) || 0;
    var valueAB5 = parseFloat(indexAB5.value) || 0;
    var valueAB6 = parseFloat(indexAB6.value) || 0;
    var valueAB7 = parseFloat(indexAB7.value) || 0;
    var valueAB8 = parseFloat(indexAB8.value) || 0;
    var valueAB9 = parseFloat(indexAB9.value) || 0;
    var valueAB10 = parseFloat(indexAB10.value) || 0;
    var valueAB11 = parseFloat(indexAB11.value) || 0;
    var valueAB12 = parseFloat(indexAB12.value) || 0;
    var valueAB13 = parseFloat(indexAB13.value) || 0;
    var valueAB14 = parseFloat(indexAB14.value) || 0;
    var valueAB15 = parseFloat(indexAB15.value) || 0;

    var indexAC0 = document.getElementById("indexAC0");
    var indexAD0 = document.getElementById("indexAD0");
    var indexAE0 = document.getElementById("indexAE0");

    var valueAC0 = parseFloat(indexAC0.value) || 0;
    var valueAD0 = parseFloat(indexAD0.value) || 0;
    var valueAE0 = parseFloat(indexAE0.value) || 0;

    var indexPA0 = document.getElementById("indexPA0");
    var indexPA1 = document.getElementById("indexPA1");
    var indexPA2 = document.getElementById("indexPA2");
    var indexPA3 = document.getElementById("indexPA3");
    var indexPA4 = document.getElementById("indexPA4");
    var indexPA5 = document.getElementById("indexPA5");

    var valuePA0 = parseFloat(indexPA0.value) || 0;
    var valuePA1 = parseFloat(indexPA1.value) || 0;
    var valuePA2 = parseFloat(indexPA2.value) || 0;
    var valuePA3 = parseFloat(indexPA3.value) || 0;
    var valuePA4 = parseFloat(indexPA4.value) || 0;
    var valuePA5 = parseFloat(indexPA5.value) || 0;

    var indexPB0 = document.getElementById("indexPB0");
    var indexPB1 = document.getElementById("indexPB1");
    var indexPB2 = document.getElementById("indexPB2");
    var indexPB3 = document.getElementById("indexPB3");
    var indexPB4 = document.getElementById("indexPB4");
    var indexPB5 = document.getElementById("indexPB5");
    var indexPB6 = document.getElementById("indexPB6");
    var indexPB7 = document.getElementById("indexPB7");
    var indexPB8 = document.getElementById("indexPB8");
    var indexPB9 = document.getElementById("indexPB9");
    var indexPB10 = document.getElementById("indexPB10");
    var indexPB11 = document.getElementById("indexPB11");
    var indexPB12 = document.getElementById("indexPB12");

    var valuePB0 = parseFloat(indexPB0.value) || 0;
    var valuePB1 = parseFloat(indexPB1.value) || 0;
    var valuePB2 = parseFloat(indexPB2.value) || 0;
    var valuePB3 = parseFloat(indexPB3.value) || 0;
    var valuePB4 = parseFloat(indexPB4.value) || 0;
    var valuePB5 = parseFloat(indexPB5.value) || 0;
    var valuePB6 = parseFloat(indexPB6.value) || 0;
    var valuePB7 = parseFloat(indexPB7.value) || 0;
    var valuePB8 = parseFloat(indexPB8.value) || 0;
    var valuePB9 = parseFloat(indexPB9.value) || 0;
    var valuePB10 = parseFloat(indexPB10.value) || 0;
    var valuePB11 = parseFloat(indexPB11.value) || 0;
    var valuePB12 = parseFloat(indexPB12.value) || 0;

    var indexPE0 = document.getElementById("indexPE0");

    var valuePE0 = parseFloat(indexPE0.value) || 0;
}

function CreateDynamicForm() {
    var submitButton = document.getElementById("submit");

    submitButton.addEventListener("click", function () {
        var formData = CreateFormData();
    });
}

window.addEventListener('DOMContentLoaded', function () {
    addIndexEventListeners();
    //CreateDynamicForm();
});