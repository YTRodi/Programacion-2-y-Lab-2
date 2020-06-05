$(document).ready(function() {

        // fix menu when passed
        $('.masthead')
            .visibility({
                once: false,
                onBottomPassed: function() {
                    $('.fixed.menu').transition('fade in');
                },
                onBottomPassedReverse: function() {
                    $('.fixed.menu').transition('fade out');
                }
            })
        ;

        // create sidebar and attach to menu open
        $('.ui.labeled.icon.sidebar')
            .sidebar('attach events', '.toc.item')
        ;

        $('.message .close')
            .on('click', function() {
                $(this)
                    .closest('.message')
                    .transition('fade')
                ;
            })
        ;

        $('.ui.form')
            .form({
                inline: true,
                on: 'blur',
                fields: {
                    contact_form_email: {
                        identifier: 'contact_form[email]',
                        rules: [
                            {
                                type   : 'email',
                                prompt : 'Por favor introduce un email'
                            }
                        ]
                    },
                    contact_form_issue: {
                        identifier: 'contact_form[issue]',
                        rules: [
                            {
                                type   : 'minLength[3]',
                                prompt : 'Por favor introduce al menos 3 caracteres'
                            }
                        ]
                    },
                    contact_form_message: {
                        identifier: 'contact_form[message]',
                        rules: [
                            {
                                type   : 'minLength[6]',
                                prompt : 'Por favor introduce al menos 6 caracteres'
                            }
                        ]
                    }
                }
            })
        ;
});

