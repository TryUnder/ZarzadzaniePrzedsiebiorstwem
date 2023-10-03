
var selectedFilters = {
    list: false,
    listName: null,
    task: false,
    taskName: null,
    today: false,
    upcoming: false,
    calendar: false,
    tags: false,
    tagNames: []
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

            SetDueDateFilter(parElements, index);
            SearchInModel();
            UpdateHeaderPar();
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

            SetDueDateFilter(parElements, index);
            SearchInModel();
            UpdateHeaderPar();
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

            SetDueDateFilter(parElements, index);
            SearchInModel();
            UpdateHeaderPar();
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

            //!!!! new works
            if (selectedFilters.calendar == false) {
                const numberElement = numberElements[index];
                bcg.classList.add('clicked');
                numberElement.classList.add('clicked_number');
            }
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

            if (selectedFilters.calendar == false) {
                const bcgElement = bcgElements[index];
                const numberElement = numberElements[index];
                bcgElement.classList.add('clicked');
                numberElement.classList.add('clicked_number');
            }
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

            if (selectedFilters.calendar == false) {
                const bcgElement = bcgElements[index];
                const numberElement = numberElements[index];
                bcgElement.classList.add('clicked');
                numberElement.classList.add('clicked_number');
            }
        });
    });
}

function SearchDbBasedOnList() {
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
    var tasks = document.getElementById("tasks");
    //taskList = parElements[index].textContent;
    var filteredTasks = [];
    var currentDay = new Date();
    if (selectedFilters.task == true && selectedFilters.list == true && selectedFilters.tags == false) {
        //list and task
        if (selectedFilters.listName != null) {
            if (selectedFilters.upcoming == true) {
                //list and upcoming
                filteredTasks = myData.planners.filter(a => a.taskList === selectedFilters.listName && new Date(a.dueDate).toLocaleDateString() > currentDay.toLocaleDateString()).flatMap(a => a.taskName);
            } else if (selectedFilters.today == true) {
                filteredTasks = myData.planners.filter(a => a.taskList === selectedFilters.listName && new Date(a.dueDate).toLocaleDateString() === currentDay.toLocaleDateString()).flatMap(a => a.taskName);
            }
        }
    }

    if (selectedFilters.task == false && selectedFilters.list == true && selectedFilters.tags == false) {
        if (selectedFilters.listName) {
            filteredTasks = myData.planners.filter(a => a.taskList === selectedFilters.listName).flatMap(a => a.taskName);
        }
    }

    if (selectedFilters.task == true && selectedFilters.list == false && selectedFilters.tags == false) {
        if (selectedFilters.upcoming == true) {
            filteredTasks = myData.planners.filter(a => new Date(a.dueDate) > currentDay).flatMap(a => a.taskName);
        } else if (selectedFilters.today == true) {
            filteredTasks = myData.planners.filter(a => new Date(a.dueDate).toLocaleDateString() === currentDay.toLocaleDateString()).flatMap(a => a.taskName);
        }
    }

    //new
    if (selectedFilters.tags === true) {
        if (selectedFilters.tagNames !== null) {
            filteredTasks = myData.planners.filter((planner) => {
                // Sprawdź, czy którykolwiek z wybranych tagów jest zawarty w zadaniach
                return selectedFilters.tagNames.some((tagName) => {
                    return planner.tags.some((tag) => tag.name === tagName);
                });
            }).map((planner) => planner.taskName);
        }
    }

    UpdateHeaderNumber(filteredTasks.length);

    if (taskContainer != null) {
        taskContainer.innerHTML = '';
    }

    if (tasks != null && selectedFilters.calendar == false) {
        tasks.innerHTML = '';
    }
    
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
        tasks.appendChild(taskContainerListItemsDiv);

        CommitTaskDetails();
    });
}

function CreateList() {
    var taskListItems = document.getElementById("task-list-items");
    var listName = prompt("Podaj nazwę listy");

    if (listName.trim() == "" || listName === null) {
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
    thirdPar.textContent = "0";

    newCol.appendChild(colImageNode);
    newRow.appendChild(newCol);
    newRow.appendChild(newPar);
    newRow.appendChild(thirdPar);

    taskListItems.insertBefore(newRow, document.getElementById("before"));

    SelectGlowListItems();
    DisplaySelectedTags();
    //UpdateTaskList(); dorenderowywanie z bazy?
    CommitTaskDetails();
    //poco to tutaj? .. zeby zaladowac nowo utworzoną listę do list..
    DisplayTaskList();
}

function CreateTag() {
    var tagsContainerFlex = document.getElementById("menu-tags-container-flex");

    var rows = tagsContainerFlex.getElementsByClassName("menu-tags-row");

        
        var menuTagsContainer = document.getElementById("menu-tags-container");
        var newRow = document.createElement("div");
        newRow.className = "menu-tags-row menu-tags-container-flex";
    

    var tagName = prompt("Podaj nazwę tagu");
    if (tagName.trim() === "" || tagName === null) {
        return;
    }


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
    LoadTagsToSelect();
    DisplaySelectedTags();
}

function UpdateHeaderPar() {
    var headerListPar = document.getElementById("header-list-par");

    const iconElements = document.querySelectorAll(".task-item-icon");
    const numberElements = document.querySelectorAll(".task-item-number");
    const parElements = document.querySelectorAll(".text-item");
    var taskInput = document.getElementById("row-input");
    var inputText = document.getElementById("input-text");
    var inputPlusIcon = document.getElementById("input-plus-icon");

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
                    DisplayCalendar();
                }
            }
        }
    });

    headerListPar.style.fontWeight = "bold";
    headerListPar.style.paddingRight = "20px;";

    if (isTodaySelected) {
        headerListPar.textContent = "Dzisiaj";
        taskInput.style.display = "inline-block";
        inputPlusIcon.style.display = "inline-block";
        inputText.style.display = "inline-block";
    } else if (isUpcomingSelected) {
        headerListPar.textContent = "Nadchodzące";
        taskInput.style.display = "inline-block";
        inputPlusIcon.style.display = "inline-block";
        inputText.style.display = "inline-block";
    } else if (isCalendarSelected) {
        headerListPar.textContent = "Kalendarz";
        taskInput.style.display = "none";
        inputPlusIcon.style.display = "none";
        inputText.style.display = "none";
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
    const tasks = document.getElementById("tasks");
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
                tasks.appendChild(taskContainerListItemsDiv);

                taskInputId.value = '';
                CommitTaskDetails();
            }
        }
    }); 
}

/*
    CommitTaskDetails() - Przypisuje zdarzenie 'click' do elementów 'tasks-container-arrow' w celu
    przekazania nazwy klikniętego zadania do sekcji po prawej stronie
*/

function CommitTaskDetails() {
    const taskContainerArrowDivs = document.querySelectorAll(".tasks-container-arrow");
    
    taskContainerArrowDivs.forEach((arrow) => {
        arrow.addEventListener("click", (event) => {
            // why
            const labelText = event.currentTarget.previousSibling.querySelector("span").textContent;
            CommitTaskName(labelText);

            const descriptionText = myData.planners.filter(a => a.taskName === labelText).flatMap(a => a.description);
            CommitTextAreaInput(descriptionText);

            const listAssigned = myData.planners.filter(a => a.taskName === labelText).flatMap(a => a.taskList).toString();
            CommitList(listAssigned);

            const dateAssigned = myData.planners.filter(a => a.taskName === labelText).flatMap(a => a.dueDate).toString();
            CommitDate(dateAssigned);

            const tagsAssigned = myData.planners.flatMap(a => a.tags);
            CommitTags(tagsAssigned);

            const subtaskAssigned = myData.planners.filter(a => a.taskName === labelText).flatMap(a => a.subtask);
            CommitSubtasks(subtaskAssigned);
        });
    });
}

/*
    Po kliknięciu w ikonkę zadania, wczytuje opis zadania
*/

function CommitTextAreaInput(description) {
    var textAreaInput = document.getElementById("textarea-input");
    textAreaInput.value = description;
}

/*
    Po kliknięciu w ikonkę zadania, wczytuje listę przypisaną do zadania
*/

function CommitList(listAssigned) {
    var selectListTask = document.getElementById("select-list-task");
    if (selectListTask) {
        for (let i = 0; i < selectListTask.options.length; i++) {
            const option = selectListTask.options[i];
            if (option.value === listAssigned) {
                selectListTask.selectedIndex = i;
                break;
            }
        }
    }
}

/*
    Po kliknięciu w ikonkę zadania, wczytuje datę przypisaną do zadania
*/

function CommitDate(dateAssigned) {
    var formattedDate = dateAssigned.split('T')[0];
    var inputDate = document.getElementById("input-date");

    if (formattedDate != null && inputDate != null) {
        inputDate.value = new Date(formattedDate).toISOString().split('T')[0];
    }
}

/*
    Po kliknięciu w ikonkę zadania, wczytuje tagi przypisane do zadania
    //sprawdzic czy dziala dla wielu tagow
*/

function CommitTags(tagsAssigned) {
    var multipleTagsInput = document.getElementById("multiple-select");

    if (multipleTagsInput != null && tagsAssigned) {
        tagsAssigned.forEach((tag) => {
            for (let i = 0; i < multipleTagsInput.options.length; i++) {
                if (multipleTagsInput.options[i].value === tag.name) {
                    multipleTagsInput.options[i].selected = true;
                    break;
                }
            }
        });
    }
}

/*
    Po kliknięciu w ikonkę zadania, wczytuje podzadania przypisane do danego zadania
*/

function CommitSubtasks(subtaskAssigned) {
    var subtaskContainerListItemDiv = document.getElementById("subtask-container-list-items");
    subtaskContainerListItemDiv.innerHTML = '';

    if (subtaskAssigned != null) {
        subtaskAssigned.forEach((subtask) => {
            var createDiv = document.createElement("div");
            var createLabel = document.createElement("label");
            createLabel.className = "checkbox";

            var createInput = document.createElement("input");
            createInput.type = "checkbox";

            var labelText = document.createElement("span");
            labelText.className = "subtask-name";
            labelText.textContent = subtask.name;
            labelText.style.marginLeft = "5px";

            createLabel.appendChild(createInput);
            createLabel.appendChild(labelText);
            createDiv.appendChild(createLabel);
            subtaskContainerListItemDiv.appendChild(createDiv);
        });
    }
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
/*
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
*/

/*
    * UpdateTaskList() - Aktualizuje opcje w elemencie 'select-list-task' na podstawie danych z bazy danych
    * Tworzy opcje w elemencie 'select-list-task' na podstawie unikalnych nazw list z bazy danych
*/
function UpdateTaskList() {
    const selectListTask = document.getElementById("select-list-task");

    // Wyczyść istniejące opcje w select-list-task, z wyjątkiem "Wybierz listę"
    while (selectListTask.firstChild) {
        selectListTask.removeChild(selectListTask.firstChild);
    }

    const defaultOption = document.createElement("option");
    defaultOption.value = "Wybierz listę";
    defaultOption.textContent = "Wybierz listę";
    selectListTask.appendChild(defaultOption);

    const existingOptions = new Set();

    myData.planners.forEach((planner) => {
        const taskList = planner.taskList.trim();

        if (!existingOptions.has(taskList)) {
            existingOptions.add(taskList);

            var option = document.createElement("option");
            option.textContent = taskList;
            selectListTask.appendChild(option);
        }
    });
}

/*
    * DisplayTaskList() *
    1) Aktualizuje opcje w elemencie 'select-list-task' na podstawie dostępnych list (text-list-item) 
       w interfejsie użytkownika
    2) Nie dodaje opcji "Wybierz listę" na początek, ponieważ jest ona już ustawiona przez UpdateTaskList()
*/
function DisplayTaskList() {
    const textListItems = document.querySelectorAll(".text-list-item");
    const selectListTaskMultiple = document.getElementById("select-list-task");

    // Wyczyść istniejące opcje w select-list-task
    selectListTaskMultiple.innerHTML = "";

    // Dodaj opcje na podstawie dostępnych list
    textListItems.forEach((task) => {
        const taskName = task.textContent.trim();
        const option = document.createElement("option");
        option.textContent = taskName;
        selectListTaskMultiple.appendChild(option);
    });
}

function LoadTagsToSelect() {
    var simple_tags_1 = document.querySelectorAll(".simple_tag_1");
    var multipleSelectId = document.getElementById("multiple-select");
    var multipleOptions = document.querySelectorAll(".option-tag");
    simple_tags_1.forEach((tag) => {
        var createOption = document.createElement("option");
        createOption.className = "option-tag";
        createOption.textContent = tag.textContent;
        multipleOptions.forEach((option) => {
            if (option.textContent === tag.textContent) {
                option.remove();
            }
        });
        multipleSelectId.appendChild(createOption);
    });
}

function CreateDynamicForm() {
    //
    var form = document.createElement("form");
    form.setAttribute("action", "/Planner/AddPlanners");
    form.setAttribute("method", "post");
    form.style.display = "none";
    //
    var submitButton = document.getElementById("save-button");
    submitButton.addEventListener("click", (event) => {
        var menuInputTask = document.getElementById("menu-input-task");
        menuInputTask.name = "Planner.TaskName";

        var descriptionInput = document.getElementById("textarea-input");
        descriptionInput.name = "Planner.Description";

        var selectListTask = document.getElementById("select-list-task");

        if (selectListTask.value != "Wybierz listę") {
            selectListTask.name = "Planner.TaskList";
            form.appendChild(selectListTask);
        }

        var dueDateInput = document.getElementById("input-date");
        dueDateInput.name = "Planner.DueDate";

        var UserIdSpan = document.createElement("input");
        UserIdSpan.value = myData.id;
        UserIdSpan.name = "Planner.userId";
        UserIdSpan.style.display = "none";


        var subtaskNameInput = document.querySelectorAll(".subtask-name");
        subtaskNameInput.forEach((subtask, index) => {
            var subtaskInput = document.createElement("input");
            subtaskInput.value = subtask.textContent;
            subtaskInput.name = `Planner.Subtask[${index}].Name`;
            subtaskInput.type = "hidden";

            form.appendChild(subtaskInput);
        });

        var tagsMultipleSelect = document.querySelectorAll(".option-tag");
        var index = 0;
        tagsMultipleSelect.forEach((tag) => {
            if (tag.selected) {
                var tagInput = document.createElement("input");
                tagInput.value = tag.textContent.trim();
                tagInput.name = `Planner.Tags[${index}].Name`;
                tagInput.type = "hidden";

                form.appendChild(tagInput);
                index++;
            }
        });

        form.appendChild(menuInputTask);
        form.appendChild(descriptionInput);
        form.appendChild(dueDateInput);
        form.appendChild(UserIdSpan);
        document.body.appendChild(form);
        form.submit();
    });
}

function DisplaySelectedTags() {
    var simpleTags1 = document.querySelectorAll(".simple_tag_1");
    simpleTags1.forEach((tag) => {
        tag.addEventListener("click", (event) => {
            if (tag.className === "simple_tag_1") {
                tag.className = "simple_tag_1 clicked_tag_1";
                selectedFilters.tags = true;
                selectedFilters.tagNames.push(tag.textContent.trim());
            } else if (tag.className === "simple_tag_1 clicked_tag_1") {
                tag.className = "simple_tag_1";
                selectedFilters.tags = false;
                selectedFilters.tagNames = selectedFilters.tagNames.filter((tagName) => tagName !== tag.textContent.trim());
            }

            SearchInModel();
        });
    });
}

function DisplayCalendar() {
    var centerContainerTasksId = document.querySelector(".tasks");

    if (centerContainerTasksId != null) {
        centerContainerTasksId.innerHTML = '';
    }

    myData.planners.sort((a, b) => {
        if (a.dueDate < b.dueDate) {
            return -1;
        } else if (a.dueDate > b.dueDate) {
            return 1;
        } 
        return 0;
    });

    myData.planners.forEach((planner) => {
        var listContainer = document.createElement("div");
        listContainer.className = "list-container";

        var headerCalendarNumber = document.createElement("span");
        headerCalendarNumber.className = "header-calendar-number";
        headerCalendarNumber.innerText = `${planner.dueDate.slice(0,10)} `;

        var plannerDay = document.createElement("span");
        plannerDay.className = "planner-day";
        plannerDay.innerText = `${planner.taskName}`;

        listContainer.appendChild(headerCalendarNumber);
        listContainer.appendChild(plannerDay);
        centerContainerTasksId.appendChild(listContainer);
    });

    UpdateHeaderNumber(myData.planners.length);
}

function LoadSubtaskFromDB() {
    var subtaskContainerListItemDiv = document.getElementById("subtask-container-list-items");

    var subtaskItems = myData.planners.flatMap(a => a.Name);
    if (subtaskItems != null) {
        subtaskItems.forEach((item) => {
            var createDiv = document.createElement("div");
            var createLabel = document.createElement("label");
            createLabel.className = "checkbox";

            var createInput = document.createElement("input");
            createInput.type = "checkbox";

            var labelText = document.createElement("span");
            labelText.className = "subtask-name";
            labelText.textContent = item.value;
            labelText.style.marginLeft = "5px";

            createLabel.appendChild(createInput);
            createLabel.appendChild(labelText);
            createDiv.appendChild(createLabel);
            subtaskContainerListItemDiv.appendChild(createDiv);
        });
    }
}


window.addEventListener('DOMContentLoaded', function () {
    SelectGlowTaskItems();
    SelectGlowListItems();
    UpdateHeaderPar();
    generateBackgroundIconColor();
    // odkomentowanie - test dzialania wysw z list
    //DisplayTaskList();
    AddTaskFromInput();
    //CommitTaskDetails();
    UpdateTaskList();
    AddSubtaskFromInput();
    CreateDynamicForm();
    LoadTagsToSelect();
    DisplaySelectedTags();
    SearchDbBasedOnList();
});