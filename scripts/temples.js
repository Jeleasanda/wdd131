// ==========================================
// 1. Footer Information (Year & Last Modified)
// ==========================================
document.getElementById("year").textContent = new Date().getFullYear();
document.getElementById("lastModified").textContent = document.lastModified;

// ==========================================
// 2. Hamburger Menu Toggle
// ==========================================
const menuButton = document.getElementById("menu");
const nav = document.getElementById("primary-nav");

menuButton.addEventListener("click", () => {
    const isOpen = nav.classList.toggle("open");
    menuButton.classList.toggle("open", isOpen);
    menuButton.setAttribute("aria-expanded", isOpen);
    menuButton.setAttribute(
        "aria-label",
        isOpen ? "Close navigation menu" : "Open navigation menu"
    );
});

// ==========================================
// 3. Temple Album Data & Rendering
// ==========================================
// IMPORTANT: The 'img' paths below MUST exactly match 
// the file names in your images folder!
const temples = [
    {
        name: "Salt Lake Temple",
        location: "Salt Lake City, Utah",
        img: "images/salt-lake-temple.jpg"
    },
    {
        name: "Provo Utah Temple",
        location: "Provo, Utah",
        img: "images/provo-utah-temple.jpg"
    },
    {
        name: "Nauvoo Illinois Temple",
        location: "Nauvoo, Illinois",
        img: "images/nauvoo-illinois-temple.jpg"
    },
    {
        name: "Rome Italy Temple",
        location: "Rome, Italy",
        img: "images/rome-italy-temple.jpg"
    },
    {
        name: "Tokyo Japan Temple",
        location: "Tokyo, Japan",
        img: "images/tokyo-japan-temple.jpg"
    },
    {
        name: "São Paulo Brazil Temple",
        location: "São Paulo, Brazil",
        img: "images/sao-paulo-brazil-temple.jpg"
    },
    {
        name: "Accra Ghana Temple",
        location: "Accra, Ghana",
        img: "images/accra-ghana-temple.jpg"
    },
    {
        name: "Sydney Australia Temple",
        location: "Sydney, Australia",
        img: "images/sydney-australia-temple.jpg"
    },
    {
        name: "Paris France Temple",
        location: "Paris, France",
        img: "images/paris-france-temple.jpg"
    }
];

const album = document.getElementById("album");

album.innerHTML = temples
    .map(
        (temple) => `
      <figure>
        <img src="${temple.img}" alt="${temple.name}, ${temple.location}" loading="lazy" width="400" height="250">
        <figcaption>
          ${temple.name}<br>
          <small>${temple.location}</small>
        </figcaption>
      </figure>
    `
    )
    .join("");