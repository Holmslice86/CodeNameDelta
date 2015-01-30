(function () {
    "use strict";
    var _baseUrl = "";

    codeNameDelta.value("appSettings", {
        BaseUrl: _baseUrl,
        Title: "Code Name Delta"
    });

    codeNameDelta.config(["$routeProvider", appConfig]);

    function appConfig($routeProvider) {

        $routeProvider.when("/", {
            templateUrl: _baseUrl + "../scripts/app/views/login.html",
            controller: "loginController as vm"
        });
    }

})();