(function () {
    'use strict';

    function JoinGameController(game, $location, errorHandler) {
        var vm = this;

        vm.joinGame = function () {
            game.join()
                .then(function (response) {
                    vm.data = response;
                    console.log('Joined Game with ID: ' + response);
                    $location.path('/api/games/play/' + response);
                }, errorHandler);
        }

        vm.joinGame();
    }

    angular.module('tictactoeApp.controllers')
        .controller('JoinGameController', ['game', '$location', 'errorHandler', JoinGameController]);
}());