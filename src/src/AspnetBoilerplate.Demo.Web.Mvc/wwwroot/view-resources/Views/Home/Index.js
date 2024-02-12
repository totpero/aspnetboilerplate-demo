$(function () {

    'use strict';


    $('#TestDateAndTime').on("click",
        function(e) {
            abp.services.app.test.testMethod({ testDate: "24.02.2024" });
        });

});
