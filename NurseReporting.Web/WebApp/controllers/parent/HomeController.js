(function () {
    'use strict';
    angular.module('app').controller('ParentHomeController', [
        '$modal', 'ChildService', 'AdmissionService',
        function ($modal, ChildService, AdmissionService) {
            var self = this;
            init();

            self.action = function (actionName, childId) {
                switch (actionName) {
                    case 'agenda':
                        showAgenda();
                        break;
                    case 'absences':
                        showAbsences(childId || null);
                        break;
                    case 'admin':
                        showAdmin();
                        break;
                }
            }

            function showAgenda() {
                var modalInstance = $modal.open({
                    animation: true,
                    templateUrl: 'WebApp/views/modal/agendaModal.html',
                    controller: 'AgendaModalController as modal',
                });
                modalInstance.result.then(function (success) {

                }, function (error) {
                });
            }

            function showAbsences(childId) {
                var modalInstance = $modal.open({
                    animation: true,
                    size: 'lg',
                    templateUrl: 'WebApp/views/modal/addAbsenceModal.html',
                    controller: 'AddAbsenceModalController as modal',
                    resolve: {
                        items: function () {
                            return {
                                childId: childId
                            };
                        }
                    }
                });
                modalInstance.result.then(function (success) {

                }, function (error) {
                });

            }

            function showAdmin() {
                var modalInstance = $modal.open({
                    animation: true,
                    templateUrl: 'WebApp/views/modal/parentAdministrationModal.html',
                    controller: 'ParentAdministrationModalController as modal',
                });
                modalInstance.result.then(function (item) {
                    AdmissionService.save(item);
                }, function (error) {
                });
            }

            function init() {

                //self.children = ["Emmanuelle di Nicola", "Yves Cotton", "Mathieu Wautier"]
                ChildService.getChildren().then(function (data) {
                    self.children = data.data;
                });
            }
        }
    ]);
}

)();