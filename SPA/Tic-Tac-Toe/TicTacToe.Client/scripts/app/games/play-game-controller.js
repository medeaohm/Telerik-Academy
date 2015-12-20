(function () {
    'use strict';

    function PlayGameController(game, $routeParams, $location, $interval, errorHandler) {
        var vm = this;
        var winner;

        console.log($routeParams.data);

        var stop = $interval(function () {
            game.status($routeParams.data)
                .then(function (data) {
                    console.log(data);
                    vm.board = data.Board;
                    vm.id = data.Id;
                    vm.state = data.State;
                    vm.firstPlayerName = data.FirstPlayerName;
                    vm.secondPlayerName = data.SecondPlayerName;

                    if (data.State == 3 || data.State == 4 || data.State == 5) {
                        if (angular.isDefined(stop)) {
                            $interval.cancel(stop);
                            stop = undefined;
                            switch (vm.state) {
                                case 3: winner = vm.firstPlayerName;
                                    break;
                                case 4: winner = vm.secondPlayerName;
                                    break;
                                default: winner = 'Draw';

                            }
                            $location.path('/api/games/winPlayer/' + winner);
                        }
                    }

                }, errorHandler);
        }, 1000);


        vm.clicked = function (row, col) {
            game.play({
                GameId: $routeParams.data,
                Row: row,
                Col: col
            });
        }
    }

    angular.module('tictactoeApp.controllers')
    .controller('PlayGameController', ['game', '$routeParams', '$location', '$interval', 'errorHandler', PlayGameController])
}());