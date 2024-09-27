'use strict';

//! HTML ELEMENTS
const nav = document.querySelector('.nav');
const menuBtn = document.querySelector('.menu-btn');
const closeBtn = document.querySelector('.close-btn');

//! EVENT HANDLERS
menuBtn.addEventListener('click', function () {
  nav.style.right = '0';
//   document.body.style.height = 'auto';
});

closeBtn.addEventListener('click', function () {
  nav.style.right = '-100%';
//   document.body.style.height = '1440px';
});
