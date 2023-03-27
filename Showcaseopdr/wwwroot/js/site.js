// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener('DOMContentLoaded', function () {
    var modal = document.getElementById("addActivityModal");
    var ActivityBtn = document.getElementById("AddActivity");
    var ActivityFormClose = document.getElementsByClassName("close")[0];

    ActivityBtn.onclick = function() {
        console.log("clicked");
        modal.style.display = "block";
    }

    ActivityFormClose.onclick = function() {
        modal.style.display = "none";
    }

    window.onclick = function(event) {
        if (event.target == modal) {
            modal.style.display = "none";
        }
    }
});

// document.addEventListener('DOMContentLoaded', function () {
//     var editModal = document.getElementById("EditActivityModal");
//     var EditActivityBtn = document.getElementById("EditActivity");
//     var EditActivityFormClose = document.getElementsByClassName("close-edit")[0];
//
//     EditActivityBtn.onclick = function() {
//         console.log("clicked");
//         editModal.style.display = "block";
//     }
//
//     EditActivityFormClose.onclick = function() {
//         editModal.style.display = "none";
//     }
//
//     window.onclick = function(event) {
//         if (event.target == editModal) {
//             editModal.style.display = "none";
//         }
//     }
// });