var map;

function createMap() {
    map = L.map('map').setView([51.505, -0.09], 13);

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(map);
}

function createMapMarkers(markerPositions) {
    console.log(markerPositions);
    var markerArray = [];
    markerPositions.forEach(element => {
        console.log(element);
        markerArray.push(L.marker([element.latitude, element.longitude]).addTo(map)
            .bindPopup(element.gve.name));
    });
    var group = L.featureGroup(markerArray).addTo(map);
    map.fitBounds(group.getBounds());
}