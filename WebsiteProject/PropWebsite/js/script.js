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
                  'Password': {
                    required: true,
                    minlength: 8,
                    maxlength: 25,
                },
                    'RepeatPassword': {
                    required: true,
                    minlength: 8,
                    maxlength: 25,
                    equalTo: "#password"
                }
            }
        });
    });
})(jQuery);