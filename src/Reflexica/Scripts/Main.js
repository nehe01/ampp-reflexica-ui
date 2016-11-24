$(function () {
                    $('#drop-area').filedrop({
                        url: '/Home/UploadFiles',
                        paramname: 'files',
                        dragOver: function () {
                            $('#drop-area').css('background', 'darkcyan');
                        },
                        dragLeave: function () {
                            $('#drop-area').css('background', 'burlywood');
                        },
                        drop: function () {
                            $('#drop-area').css('background', 'lightgrey');
                        },
                        afterAll: function () {
                            $('#drop-area').html('The file(s) have been uploaded successfully!');
                        },
                        uploadFinished: function (i, file, response, time) {
                            $('#upload-result').append('<li>' + file.name + '</li>');
                        }
                    });
  
                    $("#insert-text").click(function () {
                        $("#input-text").show();
                        $("#drop-area").hide();
                    });
                    $("#drop-file").click(function () {
                        $("#input-text").hide();
                        $("#drop-area").show();
                    });
});