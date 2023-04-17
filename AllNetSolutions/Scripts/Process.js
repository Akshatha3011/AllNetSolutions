
$(document).ready(function () {
    var startfirstTime = new Date().getTime(); // record start time
    $.ajax({
        url: 'api/process/first',
        type: 'GET',
        success: function (data) {
            if (data.length > 0) {
                var endTime = new Date().getTime(); // record end time
                var txt = "";
                $.each(data, function (i, v) {
                    txt += '<p>' + v.status + '<p>';
                    txt += '<p>' + v.timeTaken + '<p>';
                });
                var timeTaken = endTime - startfirstTime;

                var t = '<p> Time Taken: ' + timeTaken + 'ms</p>';
                $('#timeTaken1').append(t);
                $('#result1').append(txt);
            }
            console.log(data);
            console.timeEnd('myTimer');
        },
        error: function (er) {
        }
    });

    var startsecondTime = new Date().getTime(); // record start time
    $.ajax({
        url: 'api/process/second',
        type: 'GET',
        success: function (data) {
            if (data.length > 0) {
                var endTime = new Date().getTime(); // record end time
                var txt = "";
                $.each(data, function (i, v) {
                    txt += '<p>' + v.status + '<p>';
                    txt += '<p>' + v.timeTaken + '<p>';
                });
                var timeTaken = endTime - startsecondTime;

                var t = '<p> Time Taken: ' + timeTaken + 'ms</p>';
                $('#timeTaken2').append(t);
                $('#result2').append(txt);
            }
            console.log(data);
            console.timeEnd('myTimer');
        },
        error: function (er) {
        }
    });

    var startTthirdime = new Date().getTime(); // record start time
    $.ajax({
        url: 'api/process/third',
        type: 'GET',
        success: function (data) {
            if (data.length > 0) {
                var endTime = new Date().getTime(); // record end time
                var txt = "";
                $.each(data, function (i, v) {
                    txt += '<p>' + v.status + '<p>';
                    txt += '<p>' + v.timeTaken + '<p>';
                });
                var timeTaken = endTime - startTthirdime;

                var t = '<p> Time Taken: ' + timeTaken + 'ms</p>';
                $('#timeTaken3').append(t);
                $('#result3').append(txt);
            }
            console.log(data);
            console.timeEnd('myTimer');
        },
        error: function (er) {
        }
    });
});