(function () {
    'use strict';
    angular.module('app').service('ContactService', [
        '$http',
        function ($http) {
            var service = {
                get: get,
                save:save
            };

            return service;

            function get() {
                return $http.get("/api/contact");
            }

            function save(object) {
                return $http.post("/api/contact", object);
            }
        }
    ]);
}

)();