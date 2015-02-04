var fs  = require("fs");
fs.readFileSync(process.argv[2]).toString().split('\n').forEach(function (line) {
    if (line != "") {
     var datos=line.split(';');
        var texto=datos[0].split(' ');
        var posiciones=datos[1].split(' ');
        var j=0;
        var final=[];
        for(var i=0;i<posiciones.length;i++){
            final[posiciones[i]-1]=texto[j];
            j++;
        }
    var ya=false;
        for(var i=0;i<final.length;i++){
            if(typeof final[i]==='undefined'){
                final[i]=texto[j];
                ya=true;
            }
    
        }
    if(!ya){
        final[j]=texto[j];
    }
    
    console.log.apply(console,final);      
    }
});