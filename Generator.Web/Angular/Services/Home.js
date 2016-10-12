app.service("$$home", function ($http) {
    this.getInstructions = function (successCallback, errorCallback) {
        $http.get("api/instructions").then(function (response) {
            successCallback(response);
        }, function (response) {
            errorCallback(response);
        });
    };
});