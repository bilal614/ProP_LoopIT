$(document).ready(function() {
  $(function () {
  $('[data-toggle="tooltip"]').tooltip()});
    
$( "#campForm" ).validate({
  rules: {
    co_camper1: {
      required: true,
      email: true
    },
      co_camper2: {
      required: true,
      email: true
    },
      co_camper3: {
      required: false,
      email: true
    },
      co_camper4: {
      required: false,
      email: true
    },
      co_camper5: {
      required: false,
      email: true
    }}});
});

$(document).ready(function() {

   var timetable = new Timetable();
    timetable.setScope(10, 1);
    timetable.addLocations(['Main Stage', 'Jazz Reacrational Stage', 'Liquid Bar', 'Workshop']);
    
    // Main Stage
    
    timetable.addEvent('RYAN TRUESDELL & THE BRUSSELS JAZZ ORCHESTRA', 'Main Stage', new Date(2015,7,17,10,00), new Date(2015,7,17,12,00));
    timetable.addEvent('CHICK COREA & HERBIE HANCOCK', 'Main Stage', new Date(2015,7,17,12,45), new Date(2015,7,17,14,30));
    timetable.addEvent('MARCUS MILLER - AFRODEEZIA', 'Main Stage', new Date(2015,7,17,15,30), new Date(2015,7,17,17,45));
    timetable.addEvent('AVISHAI COHENS "NEW YORK DIVISION"', 'Main Stage', new Date(2015,7,17,18,45), new Date(2015,7,17,20,30));
    timetable.addEvent('D.ANGELO AND THE VANGUARD', 'Main Stage', new Date(2015,7,17,22,00), new Date(2015,7,17,24,15));
    
    
    //Jazz reacrational stage
    
    timetable.addEvent('GALLOWSTREET', 'Jazz Reacrational Stage', new Date(2015,7,17,10,45), new Date(2015,7,17,12,30));
    timetable.addEvent('BEYOND THE MEMORY - A TRIBUTE TO THE GREAT PACO DE LUCIA', 'Jazz Reacrational Stage', new Date(2015,7,17,14,30), new                           Date(2015,7,17,16,15));
    timetable.addEvent('ALABAMA SHAKES', 'Jazz Reacrational Stage', new Date(2015,7,17,18,00), new Date(2015,7,17,19,30));
    timetable.addEvent('THE STANLEY CLARKE BAND', 'Jazz Reacrational Stage', new Date(2015,7,17,20,30), new Date(2015,7,17,22,00));
    
    // Liquid Bar
    
    timetable.addEvent('JOHN ENGELS 80TH BIRTHDAY CONCERT FEATURING LEW TABACKIN', 'Liquid Bar', new Date(2015,7,17,12,00), new Date(2015,7,17,14,00));
    timetable.addEvent('JCHASTITY BROWN', 'Liquid Bar', new Date(2015,7,17,14,15), new Date(2015,7,17,15,45));
    timetable.addEvent('NTJAM ROSIE', 'Liquid Bar', new Date(2015,7,17,16,00), new Date(2015,7,17,18,00));
    timetable.addEvent('TYSHAWN SOREY TRIO', 'Liquid Bar', new Date(2015,7,17,18,15), new Date(2015,7,17,19,45));
    timetable.addEvent('JCHASTITY BROWN', 'Liquid Bar', new Date(2015,7,17,20,00), new Date(2015,7,17,22,00));
    
    //Workshop
    
    timetable.addEvent('DANCE CLASSES', 'Workshop', new Date(2015,7,17,10,00), new Date(2015,7,17,12,00));
    timetable.addEvent('INSTURMENTAL CLASSES', 'Workshop', new Date(2015,7,17,12,30), new Date(2015,7,17,16,00));
    timetable.addEvent('TEMPORARY TATTOOS', 'Workshop', new Date(2015,7,17,16,15), new Date(2015,7,17,18,30));
    timetable.addEvent('BRACELETS WORKSHOP', 'Workshop', new Date(2015,7,17,19,00), new Date(2015,7,17,21,00));

    var renderer = new Timetable.Renderer(timetable);
    renderer.draw('.timetable'); // any css selector
   
});



//Validation for registration form
 (function ($) {
    $(document).ready(function () {
        $("#registerForm").validate({
            rules: {
                'first_name': {
                    required: true,
                    minlength: 3,
                    maxlength: 20
                },
                'last_name': {
                    required: true,
                    minlength: 3,
                    maxlength: 20
                },
                'phone': {
                    required: false,
                    number: true
                },
                'email': {
                    required: true,
                    email: true,
                    minlength: 5,
                    maxlength: 100
                },
                  'password': {
                    required: true,
                    minlength: 8,
                    maxlength: 25
                },
                    'repeatpassword': {
                    required: true,
                    password_again: {
                    equalTo: "#password"
                    }
                }
            }
        });
    });
})(jQuery);