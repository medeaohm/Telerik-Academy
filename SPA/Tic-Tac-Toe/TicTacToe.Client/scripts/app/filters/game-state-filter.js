(function () {
    'use strict';

    function gameStateFilter() {
        return function (state) {
            switch (state) {
                case 0: return 'Waiting For Second Player';
                case 1: return 'TurnX';
                case 2: return 'TurnO';
                case 3: return 'WonByX';
                case 4: return 'WonByO';
                case 5: return 'Draw';
            }
        };
    }

    angular.module('tictactoeApp.controllers')
        .filter('gameStateFilter', [gameStateFilter]);
}());