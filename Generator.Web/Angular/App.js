var app = angular.module("app", ["ngRoute", "ngMessages", "ui.bootstrap"]);

app.config(function ($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl: 'Angular/Views/Home.html',
        controller: 'home'
    })
    .when("/sequences", {
        templateUrl: "Angular/Views/Sequences.html",
        controller: "sequences"
    })
    .otherwise({ redirectTo: "/" });
});