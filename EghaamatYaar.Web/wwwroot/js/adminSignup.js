'use strict';

//! HTML Elements
const inputs = document.querySelectorAll('.signup-input_input');

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
