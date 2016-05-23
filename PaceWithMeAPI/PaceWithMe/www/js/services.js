angular.module('starter.services', [])

.factory('PaceService', ['$http', function ($http) {
    var PaceService = {};

    PaceService.GetPaceList = function () {
        return $http.get("http://pacewithme.azurewebsites.net/api/PaceRecords").then(
                function handleResponse(response) {
                    pacelists = response.data;
                    return pacelists;
                });
    };

    return PaceService;
}]);