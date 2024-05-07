// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let bsModal = null; // Define a variable to store the modal instance

document.addEventListener('DOMContentLoaded', function () {
    // Initialize modal instance
    const modal = document.getElementById('form-modal');
    bsModal = new bootstrap.Modal(modal);

    // Event listener for when the modal is hidden
    modal.addEventListener('hidden.bs.modal', function () {
        // Clean up modal content when it's hidden
        $("#form-modal .modal-body").html('');
        $("#form-modal .modal-title").html('');
    });
});

showPopup = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            // Set modal content and title
            $("#form-modal .modal-body").html(res);
            $("#form-modal .modal-title").html(title);
            // Show the modal
            bsModal.show();
        }
    });
}


