$(function () {

    'use strict';


    $('#TestDateAndTime').on("click",
        function(e) {
            //abp.services.app.test.testMethod({ testDate: "24.02.2024" });
            abp.services.app.test.testMethod({ testDate: "02/24/2024" });
        });

});
