(function () {
    'use strict';

    function HomeController() {
        var vm = this;

        vm.hi = 'Welcome to good old fashioned tic-tac-toe game';
        vm.how = 'How to play:';
        vm.rules = ' Open two separate Chrom windows or Mozilla. Log in with different users. ' +
                    'Create game in the first window. Join the game in second window. ' +
                    'Game Id should be equal in both windows. ';
    }

    angular.module('tictactoeApp.controllers')
        .controller('HomeController', [HomeController]);
}());