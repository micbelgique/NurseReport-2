(function () {
    'use strict';
    angular.module('app').service('ChildService', [
        '$http',
        function ($http) {
            var service = {
                getChildren: getChildren
            };

            return service;

            function getChildren() {
                return $http.get("/api/child/getChildren");
            }
        }
    ]);
}

)();