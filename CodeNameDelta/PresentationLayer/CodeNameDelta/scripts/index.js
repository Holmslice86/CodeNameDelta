// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkID=397704
// To debug code on page load in Ripple or on Android devices/emulators: launch your app, set breakpoints, 
// and then run "window.location.reload()" in the JavaScript Console.
/// <reference group="Implicit (Multi-Device Apps)” />
(function () {
    "use strict";

    document.addEventListener( 'deviceready', onDeviceReady.bind( this ), false );

    function onDeviceReady() {
        // Handle the Cordova pause and resume events
        document.addEventListener( 'pause', onPause.bind( this ), false );
        document.addEventListener( 'resume', onResume.bind( this ), false );
        
        // TODO: Cordova has been loaded. Perform any initialization that requires Cordova here.

        //var camera = document.getElementById('camera');
        //var library = document.getElementById('library');
        //camera.addEventListener('click', getCameraPhoto, false);
        //library.addEventListener('click', getLibraryPhoto, false);
    };

    function getCameraPhoto() {
        navigator.camera.getPicture(onCameraSuccess, onFail,{quality: 50, destinationType: navigator.camera.DestinationType.DATA_URL});
    };

    function getLibraryPhoto(){
        navigator.camera.getPicture(onLibrarySuccess, onFail, {quality: 50, destinationType: navigator.camera.DestinationType.FILE_URI,
            sourceType:navigator.camera.PictureSourceType.PHOTOLIBRARY});
    };

    function onCameraSuccess(imageData){
        var el = document.createElement('div');
        el.className = 'photo';
    };

    function onLibrarySuccess(imageData) {
        var el = document.createElement('div');
        el.className = 'image';
    }

    function onFail(){

    };

    function onPause() {
        // TODO: This application has been suspended. Save application state here.
    };

    function onResume() {
        // TODO: This application has been reactivated. Restore application state here.
    };

} )();