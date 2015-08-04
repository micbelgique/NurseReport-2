(function () {
    'use strict';
    angular.module('app').service('PresenceService', [
        '$http',
        function ($http) {
            var service = {
                get: get,
                save:save
            };

            return service;

            function get() {
                return $http.get("/api/presence/");
            }

            function save(object) {
                return $http.post("/api/presence/", object);
            }
        }
    ]);
}

)();