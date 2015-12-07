$(document).ready(function() {
   var timetable = new Timetable();
    timetable.setScope(8, 4);
    timetable.addLocations(['Silent Disco', 'Nile', 'Len Room', 'Maas Room']);
    timetable.addEvent('Frankadelic', 'Nile', new Date(2015,7,17,10,45), new Date(2015,7,17,12,30));
    var renderer = new Timetable.Renderer(timetable);
    renderer.draw('.timetable'); // any css selector

});

