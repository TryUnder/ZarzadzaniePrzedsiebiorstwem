
var selectedFilters = {
    list: false,
    listName: null,
    task: false,
    taskName: null,
    today: false,
    upcoming: false,
    calendar: false
};

function SetDueDateFilter(parElements, index) {
    selectedFilters.task = true;
    if (parElements[index].textContent === "Nadchodzące") {
        selectedFilters.taskName 
        selectedFilters.upcoming = true;
        selectedFilters.today = false;
        selectedFilters.calendar = false;
    }

    if (parElements[index].textContent === "Dzisiaj") {
        selectedFilters.today = true;
        selectedFilters.upcoming = false;
        selectedFilters.calendar = false;
    }

    if (parElements[index].textContent === "Kalendarz") {
        selectedFilters.calendar = true;
        selectedFilters.today = false;
        selectedFilters.upcoming = false;
    }

    selectedFilters.taskName = parElements[index].textContent;
}

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

function SelectGlowTaskItems() {
    const iconElements = document.querySelectorAll(".task-item-icon");
    const numberElements = document.querySelectorAll(".task-item-number");
    const parElements = document.querySelectorAll(".text-item");

    iconElements.forEach((icon, index) => {
        icon.addEventListener('click', function () {

            iconElements.forEach((el) => {
                el.classList.remove('clicked');
            });

            numberElements.forEach((el) => {
                el.classList.remove('clicked_icon');
            });

            const numberElement = numberElements[index];
            icon.classList.add('clicked');
            numberElement.classList.add('clicked_icon');

            UpdateHeaderPar();
            SetDueDateFilter(parElements, index);
            SearchInModel();
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

            UpdateHeaderPar();
            SetDueDateFilter(parElements, index);
            SearchInModel();
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

            UpdateHeaderPar();
            SetDueDateFilter(parElements, index);
            SearchInModel();
        });
    });
}


function SelectGlowListItems() {
    const bcgElements = document.querySelectorAll(".list-item-bcg");
    const numberElements = document.querySelectorAll(".list-item-number");
    const parElements = document.querySelectorAll(".text-list-item");

    bcgElements.forEach((bcg, index) => {
        bcg.addEventListener('click', function () {

            bcgElements.forEach((el) => {
                el.classList.remove('clicked');
            });

            numberElements.forEach((el) => {
                el.classList.remove('clicked_number');
            });

            const numberElement = numberElements[index];
            bcg.classList.add('clicked');
            numberElement.classList.add('clicked_number');
        });
    });

    numberElements.forEach((number, index) => {
        number.addEventListener('click', function () {

            bcgElements.forEach((el) => {
                el.classList.remove('clicked');
            });

            numberElements.forEach((el) => {
                el.classList.remove('clicked_number');
            });

            const bcgElement = bcgElements[index];
            const numberElement = numberElements[index];
            bcgElement.classList.add('clicked');
            numberElement.classList.add('clicked_number');
        });
    });

    parElements.forEach((par, index) => {
        par.addEventListener('click', function () {
            bcgElements.forEach((el) => {
                el.classList.remove('clicked');
            });

            numberElements.forEach((el) => {
                el.classList.remove('clicked_number');
            });

            const bcgElement = bcgElements[index];
            const numberElement = numberElements[index];
            bcgElement.classList.add('clicked');
            numberElement.classList.add('clicked_number');
        });
    });
}

function DisplayTaskList() {
    const bcgElements = document.querySelectorAll(".list-item-bcg");
    const numberElements = document.querySelectorAll(".list-item-number");
    const parElements = document.querySelectorAll(".text-list-item");

    var taskContainer = document.getElementById("task-container");

    bcgElements.forEach((par, index) => {
        par.addEventListener('click', function () {
            selectedFilters.list = true;
            selectedFilters.listName = parElements[index].textContent;
            SearchInModel();
        });
    });

    numberElements.forEach((par, index) => {
        par.addEventListener('click', function () {
            selectedFilters.list = true;
            selectedFilters.listName = parElements[index].textContent;
            SearchInModel();
        });
    });

    parElements.forEach((par, index) => {
        par.addEventListener('click', function () {
            selectedFilters.list = true;
            selectedFilters.listName = parElements[index].textContent;
            SearchInModel();
        });
    });
}

function SearchInModel() {
    var taskContainer = document.getElementById("task-container");

    //taskList = parElements[index].textContent;
    var filteredTasks = [];

    if (selectedFilters.list == true) {
        if (selectedFilters.listName != null) {
            filteredTasks = myData.planners.filter(a => a.taskList === selectedFilters.listName).flatMap(a => a.taskName);
        }
    } else if (selectedFilters.list == false) {
        const currentDate = new Date();
        console.log(myData.planners[0].dueDate)
        if (selectedFilters.today == true) {
            filteredTasks = myData.planners.filter(a => a.dueDate === "Dzisiaj").flatMap(a => a.taskName);
        }
    }
    
    taskContainer.innerHTML = '';
    filteredTasks.forEach((taskName) => {
        var taskContainerListItemsDiv = document.createElement("div");
        taskContainerListItemsDiv.className = "tasks-container-list-items";

        var taskContainerListItemDiv = document.createElement("div");
        taskContainerListItemDiv.className = "tasks-container-list-item";

        var taskContainerArrowDiv = document.createElement("div");
        taskContainerArrowDiv.className = "tasks-container-arrow";

        var taskContainerArrowIcon = document.createElement("i");
        taskContainerArrowIcon.className = "fa-solid fa-angle-right";

        var label = document.createElement("label");
        label.className = "checkbox";

        var input = document.createElement("input");
        input.type = "checkbox";

        var labelText = document.createElement("span");
        labelText.textContent = taskName;
        labelText.style.marginLeft = "5px";

        taskContainerArrowDiv.appendChild(taskContainerArrowIcon);
        label.appendChild(input);
        label.appendChild(labelText);
        taskContainerListItemDiv.appendChild(label);
        taskContainerListItemsDiv.appendChild(taskContainerListItemDiv);
        taskContainerListItemsDiv.appendChild(taskContainerArrowDiv);
        taskContainer.appendChild(taskContainerListItemsDiv);
    });
}

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

    SelectGlowListItems();
}

function CreateTag() {
    var tagsContainerFlex = document.getElementById("menu-tags-container-flex");

    var rows = tagsContainerFlex.getElementsByClassName("menu-tags-row");

        
        var menuTagsContainer = document.getElementById("menu-tags-container");
        var newRow = document.createElement("div");
        newRow.className = "menu-tags-row menu-tags-container-flex";
    

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

function UpdateHeaderPar() {
    var headerListPar = document.getElementById("header-list-par");

    const iconElements = document.querySelectorAll(".task-item-icon");
    const numberElements = document.querySelectorAll(".task-item-number");
    const parElements = document.querySelectorAll(".text-item");

    let isTodaySelected = false;
    let isUpcomingSelected = false;
    let isCalendarSelected = false;

    iconElements.forEach((icon, index) => {
        if (icon.classList.contains('clicked')) {
            const numberElement = numberElements[index];
            if (numberElement.classList.contains('clicked_icon')) {
                const textElement = parElements[index];
                if (textElement.textContent === 'Dzisiaj') {
                    isTodaySelected = true;
                } else if (textElement.textContent === 'Nadchodzące') {
                    isUpcomingSelected = true;
                } else if (textElement.textContent === 'Kalendarz') {
                    isCalendarSelected = true;
                }
            }
        }
    });

    headerListPar.style.fontWeight = "bold";
    headerListPar.style.paddingRight = "20px;";

    if (isTodaySelected) {
        headerListPar.textContent = "Dzisiaj";
    } else if (isUpcomingSelected) {
        headerListPar.textContent = "Nadchodzące";
    } else if (isCalendarSelected) {
        headerListPar.textContent = "Kalendarz";
    }

}

function generateBackgroundIconColor() {
    var icons = document.querySelectorAll(".color-item-config");
    icons.forEach((icon) => {
        let r = Math.floor(150 + Math.random() * 155);
        let g = Math.floor(150 + Math.random() * 155);
        let b = Math.floor(150 + Math.random() * 155);

        icon.style.backgroundColor = `rgb(${r}, ${g}, ${b})`;
    });
}

window.addEventListener('DOMContentLoaded', function () {
    SelectGlowTaskItems();
    SelectGlowListItems();
    UpdateHeaderPar();
    generateBackgroundIconColor();
    DisplayTaskList();
});