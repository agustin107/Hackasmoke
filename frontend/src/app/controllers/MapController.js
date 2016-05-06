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
                        message: "<img src='assets/images/badgedino.png' width='200px' height='200px'><h5> Escuela Belgrano</h5>",
                        focus: true
                    },
                    sarmientoMarker: {
                        lat: -27.46353482,
                        lng: -58.84025596,
                        message: "<img src='assets/images/badgePiano.png' width='200px' height='200px'><h5>Escuela Sarmiento</h5>"
                    },
                    normalMarker: {
                        lat: -27.45996439,
                        lng: -58.8227534,
                        message: "<img src='assets/images/badgeTaj.png' width='200px' height='200px'><h5>Escuela Normal</h5>"
                    },
                    nacionalMarker: {
                        lat: -27.46242325,
                        lng: -58.84162854,
                        message: "<img src='assets/images/badgeNeil.png' width='200px' height='200px'><h5>Escuela Nacional</h5>"
                    }
                },
                defaults: {
                    scrollWheelZoom: false
                }
           });
    }
})();