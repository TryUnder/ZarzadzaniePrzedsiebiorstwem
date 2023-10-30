var selectedFilters = {
    rodzajAnalizy: [],
    okresRozliczeniowyPoczatek: [],
    okresRozliczeniowyKoniec: [],
    UserId: myData.id
};

function RenderButton(primaryPanel) {
    var button = document.getElementById("button");
    if (!button) {
        button = document.createElement("button");
        button.classList = "btn button is-primary";
        button.id = "button";
        button.textContent = "Dokonaj Analizy";
        primaryPanel.appendChild(button);
    } else {
        primaryPanel.appendChild(button);
    }
}

function updateFiltersInSelected(event, selectedFilter) {
    const value = event.target.nextElementSibling.textContent;
    if (event.target.checked) {
        if (!selectedFilters[selectedFilter].includes(value)) {
            if (selectedFilter === 'okresRozliczeniowyPoczatek' || selectedFilter === 'okresRozliczeniowyKoniec') {
                const date = new Date(value);
                selectedFilters[selectedFilter].push(date.toISOString());
            } else {
                selectedFilters[selectedFilter].push(value);
            }
        }
    } else {
            selectedFilters[selectedFilter] = selectedFilters[selectedFilter].filter(elem => elem !== value);
    }
    console.log(selectedFilters)
}

function HandlePanelTabs() {
    var primaryPanel = document.getElementById("primaryPanel");
    var rodzajAnalizy = document.getElementById("rodzajAnalizy");
    var okresRozliczeniowyPoczatek = document.getElementById("okresRozliczeniowyPoczatek");
    var okresRozliczeniowyKoniec = document.getElementById("okresRozliczeniowyKoniec");

    var okresRozliczeniowy = new Set();

    rodzajAnalizy.addEventListener("click", function () {
        var panelBlock = document.querySelectorAll(".panel-block");
        var rodzajAnalizyList = ["Analiza rentownosci", "Analiza zadluzenia", "Analiza plynnosci"];
        
        panelBlock.forEach(elem => {
            elem.remove();
        });

        myData.bilans.forEach(elem => {
            okresRozliczeniowy.add(elem.okresRozliczeniowy.slice(0,10));
        });

        myData.rachunkiZyskowIStrat.forEach(elem => {
            okresRozliczeniowy.add(elem.okresRozliczeniowy.slice(0,10));
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

            // reakcja na zdarzenie - zaznaczenie checkboxa
            newInput.addEventListener('change', (event) => {
                updateFiltersInSelected(event, 'rodzajAnalizy');
            });

        });
        RenderButton(primaryPanel);
        CreateDynamicForm();
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

            newInput.addEventListener('change', (event) => {
                updateFiltersInSelected(event, 'okresRozliczeniowyPoczatek');
            });
        });

        RenderButton(primaryPanel);
        CreateDynamicForm();
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

            newInput.addEventListener('change', (event) => {
                updateFiltersInSelected(event, 'okresRozliczeniowyKoniec');
            });

        });

        RenderButton(primaryPanel);
        CreateDynamicForm();
    });
}

function CreateDynamicForm() {
    var submitButton = document.getElementById("button");
    submitButton.addEventListener("click", function () {

        var formData = new FormData();
        formData.append("SelectedFilters.RodzajAnalizy", selectedFilters.rodzajAnalizy);
        formData.append("SelectedFilters.OkresRozliczeniowyPoczatek", selectedFilters.okresRozliczeniowyPoczatek);
        formData.append("SelectedFilters.OkresRozliczeniowyKoniec", selectedFilters.okresRozliczeniowyKoniec);
        formData.append("SelectedFilters.UserId", selectedFilters.UserId);

        fetch("/Finanse/DokonajAnalizy", {
            method: "POST",
            body: formData
        })
            .then(reponse => reponse.json())
            .then(data => {
                if (data.redirectUrl) {
                    window.location.href = data.redirectUrl;
                } else {
                    console.log(data);
                }
            })
            .catch(error => console.log("B³¹d: ", error));
    });
}

document.addEventListener('DOMContentLoaded', function () {
    HandlePanelTabs();
});