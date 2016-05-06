'use strict';

angular.module('app')
  .directive('panelWidget', function() {
    return {
      restrict: 'E',
      replace: true,
      transclude: true,
      scope: { title: '@', template: '@', options: '@' },
      template: '' +
                '<section class="col s12 m12>' +
                '  <div class="card-panel">' +
                '      <h3 class="panel-widget-tittle">{{title}}</h3>' +
                '      <span flex></span>' +
                '      <button ng-show="options" ng-click="$showOptions = !$showOptions" class="btn icon-button" aria-label="Show options">' +
                '        <i class="material-icons">more_vert</i>' +
                '      </button>' +
                '  </div>' +
                '  <div ng-include="template"/>' +
                '</section>',
      compile: function(element, attrs, linker) {
        return function(scope, element) {
          linker(scope, function(clone) {
            element.append(clone);
          });
        };
      }
    };
  });