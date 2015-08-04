(function () {
    'use strict';
    angular.module('app').controller('DailyObservationModalController',
        ['$modalInstance', function ($modalInstance) {
            var self = this;

            self.welcomeEvent = {};
            self.lunchEvent = {};
            self.snackEvent = {};
            self.napEvent = {};
            self.poohEvent = {};
            self.observationEvent = {};

            self.ok = function () {
                $modalInstance.close();
            };

            self.cancel = function () {
                $modalInstance.dismiss('cancel');
            };
        }
    ]);
})();