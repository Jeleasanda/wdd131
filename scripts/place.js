// 1. Footer Dates
document.getElementById("currentyear").textContent = new Date().getFullYear();
document.getElementById("lastModified").textContent = "Last Modified: " + document.lastModified;

// 2. Wind Chill Calculation
const temperature = 10; // in Celsius (matching the static value in HTML)
const windSpeed = 10;   // in km/h (matching the static value in HTML)

// Function that returns the wind chill factor using the Metric formula
function calculateWindChill(temp, speed) {
    // Formula: 13.12 + 0.6215T - 11.37V^0.16 + 0.3965TV^0.16
    return (13.12 + (0.6215 * temp) - (11.37 * Math.pow(speed, 0.16)) + (0.3965 * temp * Math.pow(speed, 0.16))).toFixed(1);
}

// Check conditions: Temp <= 10 °C and Wind speed > 4.8 km/h
const windChillSpan = document.getElementById("windchill");

if (temperature <= 10 && windSpeed > 4.8) {
    // Conditions met, calculate and display
    windChillSpan.textContent = calculateWindChill(temperature, windSpeed) + " °C";
} else {
    // Conditions not met
    windChillSpan.textContent = "N/A";
}
