
// create the controller and inject Angular's $scope
hdApp.controller('mainController', function ($scope, mainServices) {
    // create a message to display in our view
    $scope.message = 'Everyone come and see how good I look!';

    $scope.allUsers = null;

    $scope.runLoadingIcon = function () {
        $scope.allUsers = mainServices.getAllUsers();
    }

});


