﻿
var controllerId = 'SendDataCtrl';

var mod = angular.module('app', []);
mod.controller(controllerId, function ($scope, $http) {

    var person = {
        FirstName: '',
        LastName: '',
        Company: '',
        Email: '',
        Vip: false
    };
    $scope.data = person;


    function sendPost() {
        var dataJson = JSON.stringify($scope.data);
        var resourceUrl = "api/Person";


        $http.defaults.headers.post["Content-Type"] = "application/json";
        $http.post(resourceUrl, dataJson).success(function () {
            alert("Success send");
        }).error(function () { alert("Error send"); })
    }


    $scope.send = function () {
        sendPost();
    };
    function activate() {
    };

})