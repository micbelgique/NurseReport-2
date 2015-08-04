(function () {    
    angular.module('app').controller('AddChildCardModalController',
        ['$scope', '$modalInstance', 'items',
        function ($scope, $modalInstance, items) {

            var self = this;
            self.child = {};

            self.ok = function () {
                $modalInstance.close(self.child);
            };

            self.cancel = function () {
                $modalInstance.dismiss('cancel');
            };

            function init() {
                if (items.child) {
                    self.child = items.child;
                    self.child.BirthDate = new Date(self.child.BirthDate);
                    self.child.StartDate = new Date(self.child.StartDate);
                    self.child.EndDate = new Date(self.child.EndDate);
                    self.child.EstimatedEndDate = new Date(self.child.EstimatedEndDate);
                }                    
            };
            init();
        }
    ])        
})();