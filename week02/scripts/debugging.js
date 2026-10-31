const radiusOutput = document.querySelector("#radius");
const areaOutput = document.querySelector("#area");

let area = 0;
const PI = 3.14159; // <--- Error 1 is here

let radius = 10; // <--- Error 3 is here
area = PI * radius * radius;
radiusOutput.textcontent = radius; // <--- Error 2 is here
areaOutput.textcontent = area; // <--- Error 2 is here too

radius = 20; // This will break because radius is a const!
area = PI * radius * radius;
radiusOutput.textContent = radius;
areaOutput.textContent = area;