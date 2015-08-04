(function () {
    'use strict';
    angular.module('app').controller('NurseDailyController',
        ['$modal', 'ChildService',
            function ($modal, ChildService) {
            var self = this;
            
            self.addDailyObservationCard = function () {
                var modalInstance = $modal.open({
                    animation: true,
                    templateUrl: 'WebApp/views/modal/dailyObservationCardModal.html',
                    controller: 'DailyObservationModalController as observation',
                    resolve: {
                        items: function () {
                            return {}
                        }

                    }
                });

                modalInstance.result.then(function (item) {

                });                             
            };

            function init() {
                ChildService.getChildren().then(function (result) {
                    self.children = result.data;
                    self.children.forEach(function (child) {
                        child.birthdate = new Date(child.BirthDate).toLocaleDateString();
                        child.startDate = new Date(child.StartDate).toLocaleDateString();
                        child.endDate = new Date(child.EndDate).toLocaleDateString();
                    });
                });
            };
            init();
        }
    ]);
}

)();