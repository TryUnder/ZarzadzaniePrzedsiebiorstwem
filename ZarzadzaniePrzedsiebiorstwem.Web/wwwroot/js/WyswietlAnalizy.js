function HandlePanelTabs() {
    var primaryPanel = document.getElementById("primaryPanel");
    var rodzajAnalizy = document.getElementById("rodzajAnalizy");
    var okresRozliczeniowyPoczatek = document.getElementById("okresRozliczeniowyPoczatek");
    var okresRozliczeniowyKoniec = document.getElementById("okresRozliczeniowyKoniec");

    var okresRozliczeniowy = new Set();

    rodzajAnalizy.addEventListener("click", function () {
        var panelBlock = document.querySelectorAll(".panel-block");
        var rodzajAnalizyList = ["Analiza rentownoœci", "Analiza zad³u¿enia", "Analiza p³ynnoœci"];
        
        panelBlock.forEach(elem => {
            elem.remove();
        });

        myData.bilans.forEach(elem => {
            okresRozliczeniowy.add(elem.okresRozliczeniowy);
        });

        myData.rachunkiZyskowIStrat.forEach(elem => {
            okresRozliczeniowy.add(elem.okresRozliczeniowy);
        });

        rodzajAnalizyList.forEach(elem => {
            var newLabel = document.createElement("label");
            newLabel.classList = "panel-block";

            var newInput = document.createElement("input");
            newInput.type = "checkbox";

            var newSpan = document.createElement("span");
            newSpan.classList = "text";
            newSpan.textContent = elem;

            newLabel.appendChild(newInput);
            newLabel.appendChild(newSpan);
            primaryPanel.appendChild(newLabel);

        });
    });

    okresRozliczeniowyPoczatek.addEventListener("click", function () {
        var panelBlock = document.querySelectorAll(".panel-block");
        panelBlock.forEach(elem => {
            elem.remove();
        });

            okresRozliczeniowy.forEach(elem => {
            var newLabel = document.createElement("label");
            newLabel.classList = "panel-block";

            var newInput = document.createElement("input");
            newInput.type = "checkbox";

            var newSpan = document.createElement("span");
            newSpan.classList = "text";
            newSpan.textContent = elem;

            newLabel.appendChild(newInput);
            newLabel.appendChild(newSpan);
            primaryPanel.appendChild(newLabel);

        });
    });

    okresRozliczeniowyKoniec.addEventListener("click", function () {
        var panelBlock = document.querySelectorAll(".panel-block");
        panelBlock.forEach(elem => {
            elem.remove();
        });

        okresRozliczeniowy.forEach(elem => {
            var newLabel = document.createElement("label");
            newLabel.classList = "panel-block";

            var newInput = document.createElement("input");
            newInput.type = "checkbox";

            var newSpan = document.createElement("span");
            newSpan.classList = "text";
            newSpan.textContent = elem;

            newLabel.appendChild(newInput);
            newLabel.appendChild(newSpan);
            primaryPanel.appendChild(newLabel);

        });
    });
}

document.addEventListener('DOMContentLoaded', function () {
    HandlePanelTabs();
});