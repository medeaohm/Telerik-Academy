﻿(function () {
    'use strict';

    function MainController($location, auth, identity) {
        var vm = this;

        // this is for initial load of the page
        waitForLogin();

        vm.logout = function () {
            vm.globballySetCurrenUser = undefined;
            auth.logout();
            waitForLogin(); // this is for second login
        }

        function waitForLogin() {
            identity.getUser()
            .then(function (user) {
                vm.globballySetCurrenUser = user;
            });
        }
    }

    angular.module('tictactoeApp')
    .controller('MainController', ['$location', 'auth', 'identity', MainController]);
}());