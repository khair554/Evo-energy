// This is optional and can be used to add additional functionality before submitting the form
document.querySelector('form').addEventListener('submit', function(event) {
    // Add your custom functionality here

    // Prevent the default form submission behavior
    event.preventDefault();

    // Manually submit the form
    this.submit();
});