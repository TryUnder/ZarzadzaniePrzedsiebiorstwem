
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
    var currentDay = new Date().toLocaleDateString();
    if (selectedFilters.task == true && selectedFilters.list == true) {
        //list and task
        if (selectedFilters.listName != null) {
            if (selectedFilters.upcoming == true) {
                //list and upcoming
                filteredTasks = myData.planners.filter(a => a.taskList === selectedFilters.listName && new Date(a.dueDate).toLocaleDateString() > currentDay).flatMap(a => a.taskName);
            } else if (selectedFilters.today == true) {
                filteredTasks = myData.planners.filter(a => a.taskList === selectedFilters.listName && new Date(a.dueDate).toLocaleDateString() === currentDay).flatMap(a => a.taskName);
            }
        }
    }

    if (selectedFilters.task == false && selectedFilters.list == true) {
        if (selectedFilters.listName) {
            filteredTasks = myData.planners.filter(a => a.taskList === selectedFilters.listName).flatMap(a => a.taskName);
        }
    }

    if (selectedFilters.task == true && selectedFilters.list == false) {
        if (selectedFilters.upcoming == true) {
            filteredTasks = myData.planners.filter(a => new Date(a.dueDate).toLocaleDateString() > currentDay).flatMap(a => a.taskName);
        } else if (selectedFilters.today == true) {
            filteredTasks = myData.planners.filter(a => new Date(a.dueDate).toLocaleDateString() === currentDay).flatMap(a => a.taskName);
        }
    }

    UpdateHeaderNumber(filteredTasks.length);

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

        CommitTaskDetails();
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

function UpdateHeaderNumber(taskNumber) {
    var numberListPar = document.getElementById("header-list-number");
    numberListPar.textContent = taskNumber;
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

function AddTaskFromInput() {
    const taskContainer = document.getElementById("task-container");
    const taskInputId = document.getElementById("row-input");

    taskInputId.addEventListener("keypress", (event) => {
        if (event.keyCode === 13) {
            if (taskInputId != null) {

                var taskContainerListItemsDiv = document.createElement("div");
                taskContainerListItemsDiv.className = "tasks-container-list-items";
                taskContainerListItemsDiv.style = "border-top: 2px solid black; border-bottom: 2px solid black;";

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
                labelText.textContent = taskInputId.value;
                labelText.style.marginLeft = "5px";

                taskContainerArrowDiv.appendChild(taskContainerArrowIcon);
                label.appendChild(input);
                label.appendChild(labelText);
                taskContainerListItemDiv.appendChild(label);
                taskContainerListItemsDiv.appendChild(taskContainerListItemDiv);
                taskContainerListItemsDiv.appendChild(taskContainerArrowDiv);
                taskContainer.appendChild(taskContainerListItemsDiv);

                taskInputId.value = '';
                CommitTaskDetails();
            }
        }
    }); 
}

function CommitTaskDetails() {
    const taskContainerArrowDivs = document.querySelectorAll(".tasks-container-arrow");
    
    taskContainerArrowDivs.forEach((arrow) => {
        arrow.addEventListener("click", (event) => {
            // why
            const labelText = event.currentTarget.previousSibling.querySelector("span").textContent;
            CommitTaskName(labelText);
        });
    });
}

function AddSubtaskFromInput() {
    const subtaskContainerListItemDiv = document.getElementById("subtask-container-list-items");
    const subtaskInputId = document.getElementById("subtask-input");

    subtaskInputId.addEventListener("keypress", (event) => {
        if (event.keyCode == 13) {
            if (subtaskInputId != null) {
                var createDiv = document.createElement("div");
                var createLabel = document.createElement("label");
                createLabel.className = "checkbox";

                var createInput = document.createElement("input");
                createInput.type = "checkbox";

                var labelText = document.createElement("span");
                labelText.className = "subtask-name";
                labelText.textContent = subtaskInputId.value;
                labelText.style.marginLeft = "5px";

                createLabel.appendChild(createInput);
                createLabel.appendChild(labelText);
                createDiv.appendChild(createLabel);
                subtaskContainerListItemDiv.appendChild(createDiv);
                subtaskInputId.value = '';
            }
        }
    });
}

function CommitTaskName(labelText) {
    const menuInputTask = document.getElementById("menu-input-task");

    if (menuInputTask != null) {
        menuInputTask.value = labelText;
    }
}

function UpdateTaskList() {
    const selectListTask = document.getElementById("select-list-task");

    var option = document.createElement("option");
    option.textContent = "Wybierz listę";
    selectListTask.appendChild(option);

    myData.planners.forEach((planner) => {
        var option = document.createElement("option");
        option.textContent = planner.taskList;

        selectListTask.appendChild(option);
    });
}

function CreateDynamicForm() {

    var submitButton = document.getElementById("save-button");
    submitButton.addEventListener("click", (event) => {
        var subtaskInput = document.getElementById("subtask-input");
        subtaskInput.value = "test";
        subtaskInput.name = "Planner.Description";

        var descriptionInput = document.getElementById("textarea-input");

        var form = document.createElement("form");
        form.setAttribute("action", "/Planner/AddPlanners");
        form.setAttribute("method", "post");

        form.appendChild(subtaskInput);
        document.body.appendChild(form);
        form.submit();
    });
}

window.addEventListener('DOMContentLoaded', function () {
    SelectGlowTaskItems();
    SelectGlowListItems();
    UpdateHeaderPar();
    generateBackgroundIconColor();
    DisplayTaskList();
    AddTaskFromInput();
    //CommitTaskDetails();
    UpdateTaskList();
    AddSubtaskFromInput();
    CreateDynamicForm();
});