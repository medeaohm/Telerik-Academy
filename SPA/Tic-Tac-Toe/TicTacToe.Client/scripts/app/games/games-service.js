(function () {
    'use strict';

    function gameService(data) {

        function createGame() {
            return data.post('api/games/create', undefined);
        }

        function joinGame() {
            return data.post('api/games/join', undefined);
        }

        function gameStatus(id) {
            return data.get('api/games/status/?gameId=', id);
        }

        function playGame(params) {
            return data.post('api/games/play', params);
        }

        function gameScores() {
            return data.get('api/games/scores', '');
        }

        return {
            create: createGame,
            join: joinGame,
            status: gameStatus,
            play: playGame,
            scores: gameScores
        }
    }

    angular.module('tictactoeApp.services')
        .factory('game', ['data', gameService]);
}());