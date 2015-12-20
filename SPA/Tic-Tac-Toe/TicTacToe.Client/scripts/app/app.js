(function () {
    'use strict';

    function config($routeProvider, $locationProvider) {

        var CONTROLLER_VIEW_MODEL = 'vm';

        $locationProvider.html5Mode(true);

        var routeResolvers = {
            authenticationRequired: {
                authenticate: ['$q', 'auth', function ($q, auth) {
                    if (auth.isAuthenticated()) {
                        return true;
                    }
                    return $q.reject('not authorized');
                }]
            }
        }

        $routeProvider
        .when('/', {
            templateUrl: 'partials/home/home.html',
            controller: 'HomeController',
            controllerAs: CONTROLLER_VIEW_MODEL
        })
        .when('/identity/register', {
            templateUrl: 'partials/identity/register.html',
            controller: 'RegisterController',
            controllerAs: CONTROLLER_VIEW_MODEL
        })
        .when('/identity/login', {
            templateUrl: 'partials/identity/login.html',
            controller: 'LoginController',
            controllerAs: CONTROLLER_VIEW_MODEL
        })
        .when('/api/games/create', {
            templateUrl: 'partials/games/playGame.html',
            controller: 'CreateGameController',
            controllerAs: CONTROLLER_VIEW_MODEL
        })
        .when('/api/games/join', {
            templateUrl: 'partials/games/playGame.html',
            controller: 'JoinGameController',
            controllerAs: CONTROLLER_VIEW_MODEL
        })
        .when('/api/games/play/:data', {
            templateUrl: 'partials/games/playGame.html',
            controller: 'PlayGameController',
            controllerAs: CONTROLLER_VIEW_MODEL
        })
        .when('/api/games/winPlayer/:id', {
            templateUrl: 'partials/games/winPlayer.html',
            controller: 'WinPlayerController',
            controllerAs: CONTROLLER_VIEW_MODEL
        })
        .when('/api/games/scores', {
            templateUrl: 'partials/games/scores.html',
            controller: 'ScoresController',
            controllerAs: CONTROLLER_VIEW_MODEL
        })
        .otherwise({ redirectTo: '/' });
    }

    function run($http, $cookies, $rootScope, $location, auth) {
        $rootScope.$on('$routeChangeError', function (ev, current, previous, rejection) {
            if (rejection === 'not authorized') {
                $location.path('/');
            }
        });

        if (auth.isAuthenticated()) {
            $http.defaults.headers.common.Authorization = 'Bearer ' + $cookies.get('authentication');
            auth.getIdentity();
        }
    };

    angular.module('tictactoeApp.directives', []);
    angular.module('tictactoeApp.services', []);
    angular.module('tictactoeApp.controllers', ['tictactoeApp.services']);

    angular.module('tictactoeApp', ['ngRoute', 'ngCookies', 'tictactoeApp.controllers', 'tictactoeApp.directives'])
    .config(['$routeProvider', '$locationProvider', config])
    .run(['$http', '$cookies', '$rootScope', '$location', 'auth', run])
    .constant('baseUrl', 'http://localhost:33257/')
    .constant('errorHandler', function (error) { console.log(error); });
}());