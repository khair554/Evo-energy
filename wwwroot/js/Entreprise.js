document.addEventListener('DOMContentLoaded', () => {
    const registerForm = document.querySelector('.register2-container');
    const registerButton = document.querySelector('.submit');
    const rememberMeCheckbox = document.getElementById('register-check');
    const inputs = document.querySelectorAll('.input-field');
    const logoInput = document.getElementById('profile-image');

    registerButton.addEventListener('click', (event) => {
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

        // Check if passwords match
        const password = document.querySelector('input[placeholder="Mot de passe "]').value.trim();
        const confirmPassword = document.querySelector('input[placeholder="Confirmer mot de passe"]').value.trim();
        if (password !== confirmPassword) {
            isValid = false;
            alert("Les mots de passe ne correspondent pas");
        }

        if (isValid) {
            // Collect form data
            const formData = {};
            inputs.forEach(input => {
                formData[input.placeholder] = input.value.trim();
            });

            // Handle logo upload
            if (logoInput.files.length > 0) {
                const logoFile = logoInput.files[0];
                const reader = new FileReader();
                reader.onloadend = () => {
                    formData['Logo d\'entreprise'] = reader.result;
                    saveFormData(formData);
                };
                reader.readAsDataURL(logoFile);
            } else {
                saveFormData(formData);
            }
        } else {
            alert('Please fill in all required fields.');
        }
    });

    function saveFormData(formData) {
        // Handle Remember Me functionality
        if (rememberMeCheckbox.checked) {
            localStorage.setItem('rememberMe', true);
            localStorage.setItem('userData', JSON.stringify(formData));
        } else {
            localStorage.removeItem('rememberMe');
            localStorage.removeItem('userData');
        }

        console.log('Form Data:', formData);

        // Here you can handle the form data, for example, send it to a server
        // For demonstration, we'll just log it to the console
    }

    // Optional: Add event listeners for input fields to remove error class on input
    inputs.forEach(input => {
        input.addEventListener('input', () => {
            if (input.value.trim() !== '') {
                input.classList.remove('error');
            }
        });
    });

    // Load saved user data if Remember Me was checked
    if (localStorage.getItem('rememberMe')) {
        const savedData = JSON.parse(localStorage.getItem('userData'));
        inputs.forEach(input => {
            input.value = savedData[input.placeholder] || '';
        });
        rememberMeCheckbox.checked = true;
    }
});
