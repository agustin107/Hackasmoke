(function() {
    'use strict';
    
    angular.module('app')
        .controller('RankingController', [
            '$scope',
            RankingController
        ]);
    
    function RankingController($scope) {
        var vm = this;
        
        vm.bartChartData = [ 
            {
                key: "Cumulative Return",
                values: [
                    { 
                    "label" : "Sarmiento" ,
                    "value" : 10
                    } , 
                    { 
                    "label" : "Belgrano" , 
                    "value" : 5
                    } , 
                    { 
                    "label" : "Normal" , 
                    "value" : 20
                    } , 
                    { 
                    "label" : "Nacional" , 
                    "value" : 25
                    }
                ]
            }
        ];
        
        vm.barChartOptions = {
            chart: {
                type: 'discreteBarChart',
                height: 450,
                margin : {
                    top: 20,
                    right: 20,
                    bottom: 50,
                    left: 55
                },
                x: function(d){return d.label;},
                y: function(d){return d.value + (1e-10);},
                showValues: true,
                valueFormat: function(d){
                    return d3.format(',.4f')(d);
                },
                duration: 500,
                xAxis: {
                    axisLabel: 'Escuelas'
                },
                yAxis: {
                    axisLabel: 'Puntajes',
                    axisLabelDistance: -10
                }
            }
        };
        
        
        
    }
})();