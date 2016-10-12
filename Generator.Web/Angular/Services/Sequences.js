app.service("$$sequences", function ($http) {
    this.execute = function (number, successCallback, errorCallback) {
        $http.get("api/sequences/" + number).then(function (response) {
            successCallback(response);
        }, function (response) {
            errorCallback(response);
        });
    };
});