// 1. Declare variables for the input, button, and list
const input = document.querySelector("#favchap");
const button = document.querySelector("#add-btn");
const list = document.querySelector("#chapter-list");

// 2. Add a click event listener to the button
button.addEventListener("click", function () {

    // 3. Check to make sure input is not blank
    if (input.value.trim() !== "") {

        // 4. Create the list item (li) and delete button
        const li = document.createElement("li");
        const deleteButton = document.createElement("button");

        // 5. Populate the li with the input value
        li.textContent = input.value;

        // 6. Set the delete button text to an X and add accessibility label
        deleteButton.textContent = "❌";
        deleteButton.setAttribute("aria-label", "Close");

        // 7. Append the delete button to the li
        li.appendChild(deleteButton);

        // 8. Append the li to the unordered list
        list.appendChild(li);

        // 9. Add event listener to the delete button to remove the li
        deleteButton.addEventListener("click", function () {
            list.removeChild(li);
            input.focus(); // Send focus back to input
        });

        // 10. Clean up the interface
        input.value = "";
    }

    // 11. Send focus to the input element
    input.focus();
});