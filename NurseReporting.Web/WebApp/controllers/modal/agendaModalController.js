(function () {
    angular.module('app').controller('AgendaModalController',
        ['$modalInstance',
        function ($modalInstance) {
            var self = this;

            self.ok = function () {
                $modalInstance.close();
            };

            self.cancel = function () {
                $modalInstance.dismiss('cancel');
            };
        }
        ]);
})();