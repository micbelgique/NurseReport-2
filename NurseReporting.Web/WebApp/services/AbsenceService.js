(function () {
    'use strict';
    angular.module('app').service('AbsenceService', [
        '$http',
        function ($http) {
            var service = {
                get: get,
                save: save
            };

            return service;

            function get(guid) {
                return $http.get("/api/absence/" + guid);
            }

            function save(object) {
                return $http.post("/api/absence", object);
            }
        }
    ]);
}

)();