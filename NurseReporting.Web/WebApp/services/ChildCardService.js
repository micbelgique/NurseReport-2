(function () {
    'use strict';
    angular.module('app').service('ChildCardService', [
        '$http',
        function ($http) {
            var service = {
                get: get,
                save: save
            };

            return service;

            function get() {
                return $http.get("/api/childcard");
            }

            function save(object) {
                return $http.post("/api/childcard", object);
            }
        }
    ]);
}

)();