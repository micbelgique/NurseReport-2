(function () {
    'use strict';
    angular.module('app').service('AdmissionService', [
        '$http',
        function ($http) {
            var service = {
                get: get,
                save: save
            };

            return service;

            function get() {
                return $http.get("/api/admission/");
            }

            function save(object) {
                return $http.post("/api/admission", object);
            }
        }
    ]);
}

)();