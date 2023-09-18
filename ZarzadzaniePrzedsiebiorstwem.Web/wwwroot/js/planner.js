
function HideElement(id) {
    const element = document.getElementById(id);
    element.style.display = "none";
}

function HidePlaceholder(id) {
    const element = document.getElementById(id);
    element.dataset.placeholder = element.placeholder;
    element.placeholder = "";
}

function ShowElement(id, idInput) {
    const element = document.getElementById(id);
    const elementInput = document.getElementById(idInput);
    if (elementInput.value === '') {
        element.style.display = "inline-block";
    }
}

function ShowPlaceholder(id) {
    const element = document.getElementById(id);
    element.placeholder = element.dataset.placeholder;
}

function ShowIconGlow() {
    const iconElements = document.querySelectorAll(".task-item-icon");
    const numberElements = document.querySelectorAll(".task-item-number");
    const parElements = document.querySelectorAll(".text-item");

    iconElements.forEach((icon, index) => {
        icon.addEventListener('click', function() {

            iconElements.forEach((el) => {
                el.classList.remove('clicked');
            });

            numberElements.forEach((el) => {
                el.classList.remove('clicked_icon');
            });

            const numberElement = numberElements[index];
            icon.classList.add('clicked');
            numberElement.classList.add('clicked_icon');
        });
    });

    numberElements.forEach((number, index) => {
        number.addEventListener('click', function () {

            iconElements.forEach((el) => {
                el.classList.remove('clicked');
            });

            numberElements.forEach((el) => {
                el.classList.remove('clicked_icon');
            });

            const iconElement = iconElements[index];
            iconElement.classList.add('clicked');
            number.classList.add('clicked_icon');
        });
    });

    parElements.forEach((par, index) => {
        par.addEventListener('click', function () {

            iconElements.forEach((el) => {
                el.classList.remove('clicked');
            });

            numberElements.forEach((el) => {
                el.classList.remove('clicked_icon');
            });

            const iconElement = iconElements[index];
            const numberElement = numberElements[index];
            iconElement.classList.add('clicked');
            numberElement.classList.add('clicked_icon');
        });
    });
}

window.addEventListener('load', ShowIconGlow);

function CreateList() {
    var taskListItems = document.getElementById("task-list-items");
    var listName = prompt("Podaj nazwę listy");
    if (listName === '') {
        return;
    }

    var newRow = document.createElement("div");
    newRow.className = "task-list-items-inside";

    var newCol = document.createElement("div");
    newCol.className = "task-list-items-inside-item-first list-item-bcg";

    var colImageNode = document.createElement("div");
    colImageNode.className = "color-item-config";

    let r = Math.floor(Math.random() * 255);
    let g = Math.floor(Math.random() * 255);
    let b = Math.floor(Math.random() * 255);

    colImageNode.style.backgroundColor = `rgb(${ r }, ${ g }, ${ b })`;

    var newPar = document.createElement("p");
    newPar.className = "task-list-items-inside-item-second text-list-item";
    newPar.textContent = listName;

    var thirdPar = document.createElement("p");
    thirdPar.className = "task-list-items-inside-item-third list-item-number";
    thirdPar.textContent = "12";

    newCol.appendChild(colImageNode);
    newRow.appendChild(newCol);
    newRow.appendChild(newPar);
    newRow.appendChild(thirdPar);

    taskListItems.insertBefore(newRow, document.getElementById("before"));
}

function CreateTag() {
    var tagsContainerFlex = document.getElementById("menu-tags-container-flex");

    var rows = tagsContainerFlex.getElementsByClassName("menu-tags-row");

    if (rows === 0 || rows[rows.length - 1].querySelectorAll("div.simple_tag_1").length >= 3) {
        var menuTagsContainer = document.getElementById("menu-tags-container");
        var newRow = document.createElement("div");
        newRow.className = "menu-tags-row menu-tags-container-flex"
    }

    var tagName = prompt("Podaj nazwę tagu");


    let r = Math.floor(Math.random() * 255);
    let g = Math.floor(Math.random() * 255);
    let b = Math.floor(Math.random() * 255);

    var newTag = document.createElement("div");
    newTag.className = "simple_tag_1";
    newTag.style.backgroundColor = `rgb(${ r }, ${ g }, ${ b })`;

    var newPar = document.createElement("p");
    newPar.textContent = tagName;

    newTag.appendChild(newPar);
    newRow.appendChild(newTag);
    menuTagsContainer.appendChild(newRow);
}