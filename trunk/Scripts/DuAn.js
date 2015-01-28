var bermudaTriangles = [];
function showDuAn(node, map) {
    switch (node) {
        case "VUNG_BIEN":
            for (var i = 0; i < bermudaTriangles.length; i++) {
                bermudaTriangles[i].setMap(map);
            }
            break;
        case "TOA_NHA":
            for (var i = 0; i < duAn_ToaNha.length; i++) {
                duAn_ToaNha[i].setMap(map);
            }
            break;
        case "TEN":
            mar_DuAn = duAn_Ten;
            break;
        default:
            mar_DuAn = duAn_VungBien;
            break;
    }
    //alert(mar_DuAn.length);
}

function buildVungBien() {
    // Define the LatLng coordinates for the polygon's path.
    for (var i = 0; i < duAn_VungBien.length; i++) {
        var triangleCoords = [];
        //alert(duAn_VungBien[i]);
        var arr = duAn_VungBien[i].split(";");
        for (var j = 0; j < arr.length; j++) {
            //alert(arr[j]);
            if (arr[j] != "") {
                var sdouble = arr[j].split(", ");
                triangleCoords.push(new google.maps.LatLng(parseFloat(sdouble[0]), parseFloat(sdouble[1])));

                //  alert(triangleCoords.length); //
            }
        }

        
        // Construct the polygon.
        bermudaTriangle = new google.maps.Polygon({
            paths: triangleCoords,
            strokeColor: 'Blue',
            strokeOpacity: 0.8,
            strokeWeight: 2,
            fillColor: 'Green',
            fillOpacity: 0.35,
            zIndex:i
        });
        bermudaTriangles.push(bermudaTriangle);
        google.maps.event.addListener(bermudaTriangle, 'click', showArrays);
        //bermudaTriangle.setMap(map);
         //return;
    }
}
var infoWindow = new google.maps.InfoWindow();
function showArrays(event) {
    infoWindow.close();
    //alert(this.zIndex);
    // Since this polygon has only one path, we can call getPath()
    // to return the MVCArray of LatLngs.
    var vertices = this.getPath();
    var contentString = '<b>Bermuda Triangle polygon</b><br>' +
      'Clicked location: <br>' + event.latLng.lat() + ',' + event.latLng.lng() +
      '<br>';

    // Iterate over the vertices.
    for (var i = 0; i < vertices.getLength(); i++) {
        var xy = vertices.getAt(i);
        contentString += '<br>' + 'Coordinate ' + i + ':<br>' + xy.lat() + ',' +
        xy.lng();
    }

    // Replace the info window's content and position.
    infoWindow.setContent(duAn_Info[this.zIndex]);
    infoWindow.setPosition(event.latLng);

    infoWindow.open(map);
}
