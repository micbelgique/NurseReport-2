(function () {
    'use strict';
    angular.module('app').controller('MainController', [
        '$state',
        '$timeout',
        function ($state, $timeout) {
            var self = this;
            self.role = "";
            self.goTo = function (state) {
                $state.go(state);
            };

            $timeout(function () {
                var role = $("#hidRoles").val();
                console.log(role);
                switch (role) {
                    case 'Parent':
                        self.role = "parent";
                        self.goTo(self.role + '.home');
                        break;
                    case 'Nurse':
                        self.role = "nurse";
                        self.goTo(self.role + '.daily');
                        break;
                    case 'Administrator':
                        self.role = "admin";
                        self.goTo(self.role + '.home');
                        break;

                }
            }, 100);
        }
    ]);
}

)();