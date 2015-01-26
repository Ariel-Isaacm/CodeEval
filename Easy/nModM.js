var fs  = require("fs");
fs.readFileSync(process.argv[2]).toString().split('\n').forEach(function (line) {
    if (line != "") {
        var partes=line.split(',');
        var nth=parseInt(partes[0]);
        var mod=parseInt(partes[1]);
        while(nth>mod){
            nth-=mod;
        }
        console.log(nth);
    }
});