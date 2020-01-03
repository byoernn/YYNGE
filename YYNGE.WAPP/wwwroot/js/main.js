window.onload = () => {
    'use strict';

    if ('serviceWorker' in navigator) {
        navigator.serviceWorker
            .register('./js/cache-worker.js');
    }
    /** 
     * Try load WASM
     * */

    WebAssembly.instantiateStreaming(fetch('https://localhost:44359/wasm/empty.yym'))
        .then(results => {
            // Do something with the results!
            console.dir(results);
            console.debug("empty.yym loaded successfully");
        });

    //SCREEN
    function resize() {
        let canvas = document.getElementById('screen');
        let canvasRatio = canvas.height / canvas.width;
        let windowRatio = window.innerHeight / window.innerWidth;
        let width;
        let height;

        if (windowRatio < canvasRatio) {
            height = window.innerHeight;
            width = height / canvasRatio;
        } else {
            width = window.innerWidth;
            height = width * canvasRatio;
        }

        canvas.style.width = width + 'px';
        canvas.style.height = height + 'px';
    }
    window.addEventListener('resize', resize, false);
    resize();
};