var element = document.getElementById('phone');
var maskOptions = {
    mask: '0 (500) 000 0000'
};
var mask = IMask(element, maskOptions);

var submitBtn = $('#submitButton');
var submitSuccessMessage = $('#submitSuccessMessage');
var submitErrorMessage = $('#submitErrorMessage');
var form = $('#contactForm');

var tokenField = $('input[name="ReCaptchaToken"]');



grecaptcha.ready(function() {
    form.submit(function(e) {
        e.preventDefault();

        // formun ikinci kez calismasi durumu icin bunu ekledim
        submitSuccessMessage.addClass('d-none');
        submitErrorMessage.addClass('d-none');

        if(form.hasClass('loading')) {
            return;
        }

        form.addClass('loading');
        submitBtn.addClass('disabled');

        grecaptcha.execute('6LfPznQmAAAAAOb7ZvdXXRVti9eYgk31XDl7raRb', {action: 'submit'}).then(function(token) {
            tokenField.val(token);
        
            $.post('/form-gonder', form.serialize(), function(response) {
                form.removeClass('loading');
                submitBtn.removeClass('disabled');
                form[0].reset();
    
                if(response.success) {
                    submitSuccessMessage.removeClass('d-none');
                } else {
                    submitErrorMessage.removeClass('d-none');
                }
            });
            
        });
        
    });
});

