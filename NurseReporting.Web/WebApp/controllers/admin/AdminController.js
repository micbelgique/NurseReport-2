(function () {
    'use strict';
    angular.module('app').controller('AdminController', [
        '$state',
        function ($state) {
            var self = this;

            self.goToHome = function () {
                $state.go('admin.home');
            };

            self.goToReport = function () {
                $state.go('admin.report');
            };
        }
    ]);
}

)();