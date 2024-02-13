$(function () {

    'use strict';


    $('#TestDateAndTime').on("click",
        function(e) {
            //abp.services.app.test.testMethod({ testDate: "24.02.2024" });
            abp.services.app.test.testMethod({ testDate: "02/24/2024" });
        });
        
    $('#Test2').on("click",
        function(e) {
            abp.services.app.test2.testMethod().done(r => {
                console.log(r);
            });
        });

});
