app.controller("home", function ($scope, $sce, $$home) {
    $scope.instructions = $$home.getInstructions(function (response) { 
        $scope.instructions = $sce.trustAsHtml(response.data);
    }, function (response) {
        $scope.instructions = "error instructions";
    });
});