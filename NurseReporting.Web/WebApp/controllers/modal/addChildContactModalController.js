(function () {
    angular.module('app').controller('AddChildContactModalController',
        ['$scope', '$modalInstance', 'items',
        function ($scope, $modalInstance, items) {

            var self = this;
            self.contact = {};

            self.ok = function () {
                $modalInstance.close(self.contact);
            };

            self.cancel = function () {
                $modalInstance.dismiss('cancel');
            };
        }
    ])        
})();