
var baseUrl = 'http://localhost:1098/';

hdApp.factory('dataFactory', ['$http', function ($http) {

    var dataFactory = {};

    dataFactory.getAllUsers = function () {
        return $http.get(baseUrl + 'api/values/GetUsers');
    };

    return dataFactory;
}]);