(function () {
    'use strict';

    angular.module('angularSample', ['common.core', 'common.ui'])
        .config(config);

    config.$inject = ['$routeProvider'];
    function config($routeProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "Scripts/spa/home/index.html",
                controller: "indexCtrl"
            })
            .when("/key", {
                templateUrl: "Scripts/spa/account/key.html",
                controller: "keyCtrl"
            }).otherwise({ redirectTo: "/" });
    }

})();