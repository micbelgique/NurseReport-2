(function () {
    'use strict';
    angular.module('app').controller('AdminHomeController', ['$scope', '$log', '$modal', 'ChildCardService', 'ContactService',  'AdmissionService', 'ChildService',
        function ($scope, $log, $modal, ChildCardService, ContactService, AdmissionService, ChildService) {
            var self = this;
            //add actions group status
            self.addStatus = {
                isopen: false
            };

            //contact actions group status
            self.contactStatus = {
                isopen: false
            };

            self.openChildCardModal = function (child) {
                var modalInstance = $modal.open({
                    animation: true,                    
                    templateUrl: 'WebApp/views/modal/addChildCardModal.html',
                    controller: 'AddChildCardModalController as childModal',
                    resolve: {
                        items: function () {
                            return {
                                child: child
                            };
                        }
                    }
                });
                
                modalInstance.result.then(function (item) {
                    ChildCardService.save(item).then(function () {
                        init();
                    });
                });
            };

            self.editChildCard = function (child) {
                var modalInstance = $modal.open({
                    animation: true,
                    templateUrl: 'WebApp/views/modal/addChildCardModal.html',
                    controller: 'AddChildCardModalController',
                    resolve: {
                        items: function () {
                            return {
                                child: child
                            };
                        }
                    }
                });

                modalInstance.result.then(function (item) {
                    ChildCardService.save(item);
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

            self.addChildContact = function () {
                var modalInstance = $modal.open({
                    animation: true,                    
                    templateUrl: "WebApp/views/modal/addChildContactModal.html",
                    controller: "AddChildContactModalController as contactModal",
                    resolve: {
                        items: function () {
                            return {};
                        }
                    }
                });

                modalInstance.result.then(function (item) {
                    ContactService.save(item);
                });
            };

            self.addApplication = function () {
                var modalInstance = $modal.open({
                    animation: true,
                    templateUrl: 'WebApp/views/modal/addApplicationModal.html',
                    controller: 'AddApplicationModalController as applicationModal',
                    resolve: {
                        items: function () {
                            return {};
                        }
                    }
                });

                modalInstance.result.then(function (item) {
                    AdmissionService.save(item);
                });
            };

            self.toggled = function (open) {
                
            };

            self.toggleDropdown = function ($event) {
                $event.preventDefault();
                $event.stopPropagation();
                $scope.status.isopen = !$scope.status.isopen;
            };
           
        }
    ]);
}

)();