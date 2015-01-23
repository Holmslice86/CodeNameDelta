(function () {
    "use strict";
    var _baseUrl = "";

    codeNameDelta.value("appSettings", {
        BaseUrl: _baseUrl,
        Title: "Stormy Spaces"
    });

    codeNameDelta.config(["$routeProvider", appConfig]);

    function appConfig($routeProvider) {

        $routeProvider.when("/", {
            templateUrl: _baseUrl + "../Scripts/App/Views/Cloud.html",
            controller: "cloudController as vm"
        });
    }

})();