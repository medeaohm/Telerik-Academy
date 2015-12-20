(function () {
    'use strict';

    function data($http, $q, baseUrl) {

        function get(url, id) {
            var deferred = $q.defer();

            $http.get(baseUrl + url + id)
                .then(function (response) {
                    deferred.resolve(response.data);
                }, function (err) {
                    deferred.reject(err);
                });

            return deferred.promise;
        }

        function post(url, data) {
            var deferred = $q.defer();

            $http.post(baseUrl + url, data)
                .then(function (response) {
                    deferred.resolve(response.data);
                }, function (err) {
                    deferred.reject(err);
                });

            return deferred.promise;
        }

        return {
            get: get,
            post: post
        }
    }

    angular.module('tictactoeApp.services')
        .factory('data', ['$http', '$q', 'baseUrl', data])
}());