$(document).ready(function() {
  $(function () {
  $('[data-toggle="tooltip"]').tooltip()});
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