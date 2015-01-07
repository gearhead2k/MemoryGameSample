    'use strict';

    var memoryApp = angular.module('memoryGameApp', ['ngRoute', 'memoryGameModule']);

    memoryApp.config([
        '$routeProvider', function ($routeProvider) {
            $routeProvider.when('/game',
            {
                templateUrl: '/app/MemoryGame/MemoryGameBoard.htm',
                controller: 'memoryGameController'
            }).otherwise({
                templateUrl: '/app/MemoryGame/MemoryGameBoard.htm',
                controller: 'memoryGameController'
            });
        }
    ]);
