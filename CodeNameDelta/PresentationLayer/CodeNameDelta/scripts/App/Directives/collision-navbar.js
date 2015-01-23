

codeNameDelta.directive("collisionNavbar", ["$window",function ($window) {

    function setup(scope, element, attrs) {
        angular.element($window).bind("scroll", function () {

            var floatingNav = document.getElementById("floatingNav");
            var navDistanceFromTop = 380;
            var isNavFixed = false;
            var windowTop = $window.pageYOffset;
            var shouldBeFixed = windowTop > navDistanceFromTop;

            if (shouldBeFixed && !isNavFixed) {
                floatingNav.classList.add('fixedNav');
                isNavFixed = true;
            } else {
                floatingNav.classList.remove('fixedNav');
                isNavFixed = false;
            }

        });
    };

    return {
        templateUrl: "../../Scripts/App/Directives/collision-navbar.html",
        setup: setup()
    };

}]);







