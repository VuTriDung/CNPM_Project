﻿/*Menu*/
window.addEventListener("scroll", function () {
    const header = document.querySelector("header");
    if (window.scrollY === 0) {
        // Khi ở đầu trang
        header.style.background = "transparent";
        header.style.boxShadow = "none";
    } else {
        // Khi đã cuộn xuống
        header.style.background = "linear-gradient(90deg, #060707, #058697)";
        header.style.boxShadow = "0 2px 5px rgba(0,0,0,0.1)";
    }
});
// Toggle menu on mobile view
const menuToggle = document.querySelector('.menu-toggle');
const nav = document.querySelector('nav ul');

menuToggle.addEventListener('click', () => {
    nav.classList.toggle('show');
});

// Handle dropdown toggle on mobile view
const dropdownTogglers = document.querySelectorAll('.dropdown-toggler');

dropdownTogglers.forEach(toggler => {
    toggler.addEventListener('click', function (e) {
        e.preventDefault();
        const parentDropdown = this.parentElement;
        parentDropdown.classList.toggle('active');
    });
});
/* */
document.querySelectorAll('.navbar-dropdown').forEach(dropdown => {
    dropdown.addEventListener('mouseenter', function () {
        const dropdownMenu = this.querySelector('.dropdown');
        dropdownMenu.classList.add('show');
    });

    dropdown.addEventListener('mouseleave', function () {
        const dropdownMenu = this.querySelector('.dropdown');
        dropdownMenu.classList.remove('show');
    });
});
/*Phần chuyển động trong trang giới thiệu*/
document.addEventListener("DOMContentLoaded", function () {
    const fadeElements = document.querySelectorAll(".fade-in");
    function handleScroll() {
        fadeElements.forEach(element => {
            const rect = element.getBoundingClientRect();
            if (rect.top < window.innerHeight - 100) {
                element.classList.add("active");
            }
        });
    }
    window.addEventListener("scroll", handleScroll);
    handleScroll();
});
