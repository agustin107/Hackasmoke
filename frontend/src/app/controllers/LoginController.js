(function() {
   'use strict';
   
   angular.module('app')
    .controller('LoginController', [
        '$scope',
        '$state',
        LoginController
    ]);
    
    function LoginController($scope, $state) {
        var vm = this;
        
        vm.login = login;
        vm.register = register;
        
        function login() {
            if(vm.email === 'test@test.com' && vm.password === 'test') {
                $state.go('home.dashboard')
            }
        }
        
        function register() {
            $state.go('register');
        }
    }
})();