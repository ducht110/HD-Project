
// create the controller and inject Angular's $scope
hdApp.controller('mainController', ['$scope', 'dataFactory', function ($scope, dataFactory) {
    // create a message to display in our view
    $scope.pageTitle = 'Home';
    $scope.message = 'Everyone come and see how good I look!';
    $scope.allUsers;

    $scope.getUsers = function () {
        $scope.allUsers = dataFactory.getAllUsers()
            .success(function (result) {
                $scope.allUsers = result;
            })
            .error(function (error) {
                $scope.message = 'Unable to load customer data: ' + error.message;
            });
    }

}]);


