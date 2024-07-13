document.addEventListener('DOMContentLoaded', () => {
    const form = document.querySelector('.form-box');
    const inputs = document.querySelectorAll('.input-field');
    const submitButton = document.querySelector('.submit');

    // Add event listener for form submission
    submitButton.addEventListener('click', (event) => {
        event.preventDefault(); // Prevent default form submission

        let isValid = true;

        // Simple validation for each input field
        inputs.forEach(input => {
            if (input.value.trim() === '') {
                isValid = false;
                input.classList.add('error');
            } else {
                input.classList.remove('error');
            }
        });

        if (isValid) {
            // Collect form data
            const formData = {};
            inputs.forEach(input => {
                formData[input.placeholder] = input.value.trim();
            });

            // Get selected Gouvernorat
            const gouvernoratSelect = document.getElementById('Choix de Gouvernorat');
            formData['Gouvernorat'] = gouvernoratSelect.options[gouvernoratSelect.selectedIndex].value;

            console.log('Form Data:', formData);

            // Here you can handle the form data, for example, send it to a server
            // For demonstration, we'll just log it to the console
        } else {
            alert('Please fill in all required fields.');
        }
    });

    // Optional: Add event listeners for input fields to remove error class on input
    inputs.forEach(input => {
        input.addEventListener('input', () => {
            if (input.value.trim() !== '') {
                input.classList.remove('error');
            }
        });
    });
});
