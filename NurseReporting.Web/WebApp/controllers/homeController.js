(function () {
    'use strict';
    angular.module('app').controller('HomeController', [
        '$scope', '$modal', '$log',
            function ($scope, $modal, $log) {
                var self = this;

                self.items = ['item1', 'item2', 'item3'];

                self.animationsEnabled = true;

                self.open = function (size) {

                    var modalInstance = $modal.open({
                        animation: self.animationsEnabled,
                        templateUrl: 'WebApp/views/testModal.html',
                        controller: 'TestModalController as testModal',
                        size: size,
                        resolve: {
                            items: function () {
                                return self.items;
                            }
                        }
                    });

                    modalInstance.result.then(function (selectedItem) {
                        self.selected = selectedItem;
                    }, function (error) {
                        $log.info('Modal dismissed at: ' + new Date());
                    });
                };

                self.toggleAnimation = function () {
                    self.animationsEnabled = !self.animationsEnabled;
                };
            }
        ]);
    }

)();