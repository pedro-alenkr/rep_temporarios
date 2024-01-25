function Send(event, url) {
    event.preventDefault();
    var form = $('#form')[0];
 
    if (form.checkValidity() === false) 
    {
        event.stopPropagation();
        form.reportValidity(); 
    }

    else {
        var form_data = $('#form').serialize();
 
        $.ajax({
            type: "POST",
            url: url,
            data: form_data,
            dataType: "json",
 
            success: function (response) {
                if (response.success) {
                    bootstrapNotify('Operation successful.','success');
                }
                else{
                    bootstrapNotify('Operation failed.','error');
                }
            },
 
            error: function () { 
                bootstrapNotify('Sistem error.','error');
            }
        });
    }
 }