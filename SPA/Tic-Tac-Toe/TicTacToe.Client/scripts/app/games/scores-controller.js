(function () {
    'use strict';

    function ScoresController(game, $routeParams, $location, errorHandler) {
        var vm = this;

        vm.scores = function () {
            game.scores()
                .then(function (response) {
                    vm.gameScores = response;
                }, errorHandler);
        }

        vm.scores();
    }
    
    angular.module('tictactoeApp.controllers')
        .controller('ScoresController', ['game', '$routeParams', '$location', 'errorHandler', ScoresController]);
}());