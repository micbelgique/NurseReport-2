(function () {
    angular.module('app').controller('AddApplicationModalController',
        ['$scope', '$modalInstance', 'items',
        function ($scope, $modalInstance, items) {

            var self = this;
            self.admission = {
                applicationDate: new Date(),
                from: new Date(),
                receptionDate: getDefaultReceptionDate()
            };
            init();

            self.ok = function () {
                self.admission.acceptedDate = new Date();
                self.admission.requestDate = new Date();
                $modalInstance.close(self.admission);
            };

            self.cancel = function () {
                $modalInstance.dismiss('cancel');
            };

            function getDefaultReceptionDate() {
                var date = new Date();
                if (date.getDay() == 6)
                    date.setDate(date.getDate() + 2)
                else if (date.getDay() == 0)
                    date.setDate(date.getDate() + 1)

                return date;
            };

            function init() {
                self.langues = [{
                    id: 1,
                    value: "Français"
                }, {
                    id: 2,
                    value: "Néerlandais"
                }];
                self.nbDays = [{
                    id: 1,
                    value: "1"
                }, {
                    id: 2,
                    value: "2"
                }, {
                    id: 3,
                    value: "3"
                }, {
                    id: 4,
                    value: "4"
                }, {
                    id: 5,
                    value: "5"
                }];
            }
        }
    ])        
})();