document.addEventListener('DOMContentLoaded', () => {
    const confirmButton = document.querySelector('.button-5');
    const checkboxes = document.querySelectorAll('input[type="checkbox"]');
    const textarea = document.getElementById('additional-info');

    confirmButton.addEventListener('click', (event) => {
        event.preventDefault(); // Prevent default form submission

        // Collect selected services
        const selectedServices = [];
        checkboxes.forEach(checkbox => {
            if (checkbox.checked) {
                const label = checkbox.parentElement.querySelector('span').innerText;
                selectedServices.push(label);
            }
        });

        // Collect additional information
        const additionalInfo = textarea.value.trim();

        // Combine all data into a single object
        const formData = {
            selectedServices: selectedServices,
            additionalInfo: additionalInfo
        };

        console.log('Form Data:', formData);

        // Here you can handle the form data, for example, send it to a server
        // For demonstration, we'll just log it to the console
    });
});
