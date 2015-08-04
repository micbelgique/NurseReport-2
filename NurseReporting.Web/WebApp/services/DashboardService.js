(function () {
    'use strict';
    angular.module('app').service('DashboardService', [
        '$http',
        function ($http) {
            var service = {
                get: get
            };

            return service;

            function get() {
                return $http.get("/api/dashboard/");
            }
        }
    ]);
}

)();