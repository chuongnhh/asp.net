var contact = {
    init: function () {
        contact.registerEvents();
    },
    registerEvents: function () {
        $("#btnSend").off('click').on('click', function () {
            var name = $('#txtName').val();
            var phone = $('#txtPhone').val();
            var email = $('#txtEmail').val();
            var address = $('#txtAdress').val();
            var content = $('#txtContent').val();

            $.ajax({
                url: 'Contact/Send',
                type: 'POST',
                dataType: 'json',
                data: {
                    name: name,
                    phone: phone,
                    email: email,
                    address: address,
                    content: content
                },
                success: function (res) {
                    if (res.status == true) {
                        window.alert('Gửi thành công');
                    }
                }
            })
        });
    }
}
contact.init();