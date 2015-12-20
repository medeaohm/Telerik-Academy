(function () {
    'use strict';

    function listedPlayersDirective() {
        return {
            restrict: 'A',
            templateUrl: 'partials/games/listed-players-directive.html'
        }
    }

    angular.module('tictactoeApp.directives')
        .directive('listedPlayersDirective', [listedPlayersDirective])
}());