(function () {

    "use strict";

    codeNameDelta.controller("homeController", ["$window", homeController]);

    function homeController($window) {

        var vm = this;
        var _answer = "Yes";

        var _panels = [
        {
            panelHeader: "Creative Design",
            panelBody: "We are very creative!"
        },
        {
            panelHeader: "Cutting Edge Technology",
            panelBody: "We use cutting edge tech!"

        },
        {
            panelHeader: "With a Personal Touch",
            panelBody: "We treat all of our customers as if they were family"
        }
        ];


        vm.Answer = _answer;
        vm.Panels = _panels;
    }

})();