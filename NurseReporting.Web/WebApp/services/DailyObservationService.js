(function () {
    'use strict';
    angular.module('app').service('DailyObservationService', [
        '$http',
        function ($http) {
            var service = {
                get: get,
                save: save
            };

            return service;

            function get() {
                return $http.get("/api/dailyobservations");
            }

            function save(object) {
                return $http.post("/api/dailyobservations", object);
            }
        }
    ]);
}

)();