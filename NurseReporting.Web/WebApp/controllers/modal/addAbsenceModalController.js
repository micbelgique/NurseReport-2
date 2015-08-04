(function () {
    angular.module('app').controller('AddAbsenceModalController',
        ['$modalInstance',
            'AbsenceService',
            'items',
        function ($modalInstance, AbsenceService, items) {
            var self = this;
            init();

            self.absence = {};
            self.absence.ChildIDs = [items.childId];

            self.ok = function () {
                AbsenceService.save(self.absence).then(function () {
                    $modalInstance.close();
                }, function () {
                    //alert("An error occured while saving absence.");
                    self.hasError = true;
                })
            };

            self.cancel = function () {
                $modalInstance.dismiss('cancel');
            };

            function init() {
                AbsenceService.get(items.childId).then(function (data) {
                    self.raisons = data.data.Reasons;
                    console.log(self.raisons);
                });
            }
        }
        ]);
})();