(function () {
    angular.module('app').controller('TestModalController',
        ['$scope', '$modalInstance', 'items',
        function ($scope, $modalInstance, items) {
            var self = this;
            self.items = items;
            self.selected = {
                item: self.items[0]
            };

            self.ok = function () {
                $modalInstance.close(self.selected.item);
            };

            self.cancel = function () {
                $modalInstance.dismiss('cancel');
            };
        }
    ])    
})();
