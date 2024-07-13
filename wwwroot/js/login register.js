// JavaScript code
function scrollToServices() {
    document.querySelector('.services').scrollIntoView({ behavior: 'smooth' });
}document.addEventListener('DOMContentLoaded', function() {
	var loginButton = document.querySelector('#login-button');
	var registerButton = document.querySelector('#register-button');

	loginButton.addEventListener('click', function() {
		// Show the login form
		alert('Login form displayed');
	});

	registerButton.addEventListener('click', function() {
		// Show the register form
		alert('Register form displayed');
	});
});