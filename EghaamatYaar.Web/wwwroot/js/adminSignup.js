'use strict';

//! HTML Elements
const inputs = document.querySelectorAll('.signup-input_input');
const hideBtn = document.querySelector('.hide-btn');
const passwordInput = document.getElementById('password');

//! Event Handlers
inputs.forEach(function (input) {
  input.addEventListener('focus', function () {
    input.nextElementSibling.classList.add('input-focus-fill');
  });
  input.addEventListener('blur', function () {
    if (input.value === '') {
      input.nextElementSibling.classList.remove('input-focus-fill');
    }
  });
});

hideBtn.addEventListener('click', function (e) {
  e.preventDefault();
  const newType =
    passwordInput.getAttribute('type') === 'password' ? 'text' : 'password';
  let newIconSrc;
  if (newType === 'text') {
    newIconSrc = hideBtn.querySelector('img').src.replace('hide', 'show');
  } else {
    newIconSrc = hideBtn.querySelector('img').src.replace('show', 'hide');
  }
  hideBtn.querySelector('img').setAttribute('src', newIconSrc);
  passwordInput.setAttribute('type', newType);
});
