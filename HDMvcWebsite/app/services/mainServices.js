hdApp.service('mainServices', function ($http) {
    this.getAllUsers = function () {
        //return [{ firstName: 'Anna', age: 18 }, { firstName: 'Kelly', age: 28 }];
        $http.get(baseUrl + 'api/values/GetUsers').then(function (results) {
            return results.data;
        });
    }
});