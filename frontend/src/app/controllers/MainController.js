(function(){

  angular
       .module('app')
       .controller('MainController', [
          '$log', '$q', '$state',
          MainController
       ]);

  function MainController($log, $q, $state) {
    var vm = this;

    vm.menuItems = [ ];

  }

})();
