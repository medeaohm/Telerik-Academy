(function () {
    'use strict';

    function WinPlayerController($routeParams) {
        var vm = this;
        console.log($routeParams.id);
        vm.winner = $routeParams.id;
    }

    angular.module('tictactoeApp.controllers')
        .controller('WinPlayerController', ['$routeParams', WinPlayerController]);
}());