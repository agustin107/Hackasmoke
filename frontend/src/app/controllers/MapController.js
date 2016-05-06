(function() {
    'use strict';
    
    angular.module('app')
        .controller('MapController', [
            '$scope',
            MapController
        ]);
    
    function MapController($scope) {
           angular.extend(this, {
                center: {
                    lat: -27.4692,
                    lng: -58.8306,
                    zoom: 14
                },
                markers: {
                    belgranoMarker: {
                        lat: -27.46933539,
                        lng: -58.83093188,
                        message: "Manuel Belgrano",
                        focus: true
                    },
                    sarmientoMarker: {
                        lat: -27.46353482,
                        lng: -58.84025596,
                        message: "Sarmiento"
                    },
                    normalMarker: {
                        lat: -27.45996439,
                        lng: -58.8227534,
                        message: "Normal"
                    },
                    nacionalMarker: {
                        lat: -27.46242325,
                        lng: -58.84162854,
                        message: "Nacional"
                    }
                },
                defaults: {
                    scrollWheelZoom: false
                }
           });
    }
})();