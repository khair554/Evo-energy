const form = document.querySelector('form');

form.addEventListener('submit', (e) => {
    e.preventDefault();

    const username = document.querySelector('#username').value;
    const password = document.querySelector('#password').value;

    // Do something with the username and password (e.g. submit to a server)

    console.log(`Username: ${username}, Password: ${password}`);
});