    'use strict';
    
    angular
        .module('memoryGameModule')
        .controller('memoryGameController', ['$scope', function($scope) {
            $scope.hello = 'hello world';
            var vm = this;

            $scope.cards = [
            {
                id:1,
                name: 'Test1'
            },
            {
                id:2,
                name:'Test2'
            },  
            {
                id: 3,
                name: 'Test3'
            },
            {
                id: 4,
                name: 'Test4'
            },
            {
                id: 5,
                name: 'Test5'
            },
            {
                id: 100,
                name: 'Test100'
            },
            {
                id: 7,
                name: 'Testaa7'
            },
            {
                id: 8,
                name: 'Test8'
            },
            {
                id: 9,
                name: 'Test9'
            },
            {
                id: 10,
                name: 'Test10'
            },
            {
                id: 11,
                name: 'Test11'
            }];

        }]);

    

    

