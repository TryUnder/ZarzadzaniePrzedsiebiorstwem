function HandlePanelTabs() {
    var primaryPanel = document.getElementById("primaryPanel");
    var rodzajAnalizy = document.getElementById("rodzajAnalizy");
    var okresRozliczeniowyPoczatek = document.getElementById("okresRozliczeniowyPoczatek");
    var okresRozliczeniowyKoniec = document.getElementById("okresRozliczeniowyKoniec");

    rodzajAnalizy.addEventListener("click", function () {
        var panelBlock = document.querySelectorAll(".panel-block");
        var rodzajAnalizyList = ["Analiza rentownoœci", "Analiza zad³u¿enia", "Analiza p³ynnoœci"];
        panelBlock.forEach(elem => {
            elem.remove();
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
        myData.bilans.forEach((elem) => {
            var newLabel = document.createElement("label");
            newLabel.classList = "panel-block";

            var newInput = document.createElement("input");
            newInput.type = "checkbox";

            var newSpan = document.createElement("span");
            newSpan.classList = "text";
            newSpan.textContent = elem.okresRozliczeniowy;

            newLabel.appendChild(newInput);
            newLabel.appendChild(newSpan);
            primaryPanel.appendChild(newLabel);
        });

        myData.rachunkiZyskowIStrat.forEach((elem) => {
            var newLabel = document.createElement("label");
            newLabel.classList = "panel-block";

            var newInput = document.createElement("input");
            newInput.type = "checkbox";

            var newSpan = document.createElement("span");
            newSpan.classList = "text";
            newSpan.textContent = elem.dataPoczatkowa;

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
        myData.bilans.forEach((elem) => {
            var newLabel = document.createElement("label");
            newLabel.classList = "panel-block";

            var newInput = document.createElement("input");
            newInput.type = "checkbox";

            var newSpan = document.createElement("span");
            newSpan.classList = "text";
            newSpan.textContent = elem.okresRozliczeniowy;

            newLabel.appendChild(newInput);
            newLabel.appendChild(newSpan);
            primaryPanel.appendChild(newLabel);
        });

        myData.rachunkiZyskowIStrat.forEach((elem) => {
            var newLabel = document.createElement("label");
            newLabel.classList = "panel-block";

            var newInput = document.createElement("input");
            newInput.type = "checkbox";

            var newSpan = document.createElement("span");
            newSpan.classList = "text";
            newSpan.textContent = elem.dataKoncowa;

            newLabel.appendChild(newInput);
            newLabel.appendChild(newSpan);
            primaryPanel.appendChild(newLabel);
        });
    });
}

document.addEventListener('DOMContentLoaded', function () {
    HandlePanelTabs();
});