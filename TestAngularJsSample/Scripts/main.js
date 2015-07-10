var myNgApp = angular.module('main', []);

myNgApp.factory('Friends', function () {
    var Friends = {};
    Friends.ListOfFriend = [
        {
            name: "Sagar Khyaju",
            knowJs: true
        },
        {
            name: "Shyam Suwal",
            knowJs: false
        },
        {
            name: "Rameswor Suwal",
            knowJs: false
        }
    ];
    return Friends;
});

myNgApp.controller('FriendsController', function ($scope, Friends) {
    $scope.Friends = Friends;
});

myNgApp.factory('Data', function () {
    return {
        IsSuccess: true,
        Message: "Message from service"
    };
});

myNgApp.filter('reverseString', function () {
    return function (text) {
        return text.split("").reverse().join("");
    };
});

//function firstController($scope) {

//}
myNgApp.controller('firstController', function ($scope, Data) {
    $scope.data = Data;
});

myNgApp.controller('secondController', function ($scope, Data) {
    $scope.data = Data;
    $scope.ReversedMessage = function (messageToReverse) {
        return messageToReverse.split("").reverse().join("");
    };
});