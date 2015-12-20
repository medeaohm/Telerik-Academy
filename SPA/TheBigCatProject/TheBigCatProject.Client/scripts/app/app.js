/// <reference path="C:\Users\Adrian\Desktop\Telerik-Academy\SPA\TheBigCatProject\TheBigCatProject.Client\partials/identity/register.html" />
/// <reference path="C:\Users\Adrian\Desktop\Telerik-Academy\SPA\TheBigCatProject\TheBigCatProject.Client\partials/identity/register.html" />
(function () {
    'use strict';


    function config($routeProvider, $locationProvider) {

        var CONTROLLER_VIEW_MODEL_NAME = 'vm';

        var RouteResolvers = {
            authenticationRequired: {
                authenticate: ['$q', 'auth', function ($q, auth) {
                    if ( auth.isAuthenticated()) {
                        return true;
                    }
                    return $q.reject('not authorized');
                }]
            }
        }

        $locationProvider.html5Mode(true);

        $routeProvider
            .when('/', {
                templateUrl: 'partials/home/home.html',
                controller: 'HomeController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/identity/register', {
                templateUrl: 'partials/identity/register.html',
                controller: 'RegisterController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/identity/login', {
                templateUrl: 'partials/identity/login.html',
                controller: 'LoginController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/cats/add', {
                templateUrl: 'partials/cats/add-cat.html',
                controller: 'AddCatController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME,
                resolve: RouteResolvers.authenticationRequired              
            })
            .when('/cats', {
                templateUrl: 'partials/cats/search-cats.html',
                controller: 'SearchCatsController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME                
            })
            .otherwise({ redirectTo: '/' })
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


    angular.module('catApp.services', []);
    angular.module('catApp.directives', []);
    angular.module('catApp.controllers', ['catApp.services']);

    angular.module('catApp', ['ngRoute', 'ngCookies', 'catApp.controllers', 'catApp.directives'])
        .config(['$routeProvider', '$locationProvider', config])
        .run(['$http', '$cookies', '$rootScope', '$location', 'auth', run])
        .constant('baseUrl', 'http://localhost:55068');
}());