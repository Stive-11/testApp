
    var controllerId = 'SendDataCtrl';

    var mod = angular.module('app',[]);
    mod.controller(controllerId, function ($scope,  $http) {

        var person = {
            FirstName:'',
            LastName: '',
            Company: '',
            Email: '',
            VIP: false
        };
        $scope.data = person;


         function sendPost() {
             var dataJson = JSON.stringify($scope.data);
             var resourceUrl = "api/Person/post";
             
             
             $http.defaults.headers.post["Content-Type"] = "application/x-www-form-urlencoded";
             $http.post(resourceUrl, dataJson).success(function () {

                alert("111");
             }).error(function () { alert("Error send");})
        }
        
       
        $scope.send = function () {
            sendPost();
        };
        function activate() {
        };

    }) 
