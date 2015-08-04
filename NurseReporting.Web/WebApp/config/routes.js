(function () {

    angular.module('app').config(function ($stateProvider, $urlRouterProvider) {
        //
        // For any unmatched url, redirect to /state1
        //$urlRouterProvider.otherwise("/test");
        //
        // Now set up the states
        $stateProvider
            .state('admin', {
                url: "/admin",
                templateUrl: "WebApp/views/admin/dashboard.html",
                controller: "AdminController as admin",
                abstract: true
            }).state('admin.home', {
                url: "",
                templateUrl: "WebApp/views/admin/home.html",
                controller: "AdminHomeController  as home"
            }).state('admin.report', {
                url: '/report',
                templateUrl: 'WebApp/views/admin/report.html',
                contorller : 'AdminReportController as report'
            }).state('nurse', {
                url: "/nurse",
                templateUrl: "WebApp/views/nurse/dashboard.html",
                controller: "NurseController as nurse",
                abstract: true
            }).state('nurse.daily', {
                url: "",
                templateUrl: "/WebApp/views/nurse/daily.html",
                controller: "NurseDailyController  as daily"
            }).state("parent", {
                url: "/parent",
                templateUrl: "/WebApp/views/parent/dashboard.html",
                controller: "ParentController  as parent",
                abstract: true
            }).state("parent.home", {
                url: "",
                templateUrl: "/WebApp/views/parent/home.html",
                controller: "ParentHomeController as  home"
            });
    });
})();