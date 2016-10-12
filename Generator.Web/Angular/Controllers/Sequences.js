app.controller("sequences", function ($scope, $$sequences) {
    $scope.number = 1;
    $scope.display = "display:none";
    $scope.data = null;
    $scope.execute = function () {
        $$sequences.execute($scope.number, function (response) {
            $scope.data = response.data;
            $scope.display = "display:block";
        }, function (response) {
            // TODO: show error alerts
        });
    }
});