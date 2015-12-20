(function () {
    'use strict';

    function MainController(auth, identity) {
        var vm = this;

        // this is for initial load of the page
        waitForLogin();

        vm.logout = function () {
            vm.globallySetCurrentUser = undefined;
            auth.logout();
            waitForLogin(); // this is for second login
        }

        function waitForLogin() {
            identity.getUser()
            .then(function (user) {
                vm.globallySetCurrentUser = user;
                console.log(vm.globallySetCurrentUser);
            });
        }
    }

    angular.module('catApp')
    .controller('MainController', ['auth', 'identity', MainController]);
}());