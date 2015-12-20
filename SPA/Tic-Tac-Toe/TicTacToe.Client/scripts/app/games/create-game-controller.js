(function () {
    'use strict';

    function CreateGameController(game, $routeParams, $location, errorHandler) {
        var vm = this;

        vm.createGame = function () {
            game.create()
                .then(function (response) {
                    vm.data = response;
                    console.log('Game Created with ID: ' + response);
                    $location.path('/api/games/play/' + response);
                }, errorHandler);
        }

        vm.createGame();
    }

    angular.module('tictactoeApp.controllers')
        .controller('CreateGameController', ['game', '$routeParams', '$location', 'errorHandler', CreateGameController]);
}());