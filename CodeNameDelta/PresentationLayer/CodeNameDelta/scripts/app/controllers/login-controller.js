(function () {
    "use strict";

    codeNameDelta.controller("loginController", [loginController]);
    function loginController() {
        var vm = this;
        var _username = "";
        var _password = "";

        function _login() {
            alert('username:' + _username+ ' password:' + _password);
        };
        vm.Login = _login;
        vm.Username=_username;
        vm.Password=_password;
    };



})();