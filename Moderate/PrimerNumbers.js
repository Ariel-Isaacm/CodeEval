var fs  = require("fs");
fs.readFileSync(process.argv[2]).toString().split('\n').forEach(function (line) {
    if (line != "") {
var num=parseInt(line);
var veces=0;
var numeros="";
for(var i=2;i<num;i++){
    for(var j=1;j<i;j++){
        if(i%j===0){
            veces++;
        }
     }
    if(veces<2){
        numeros=numeros+","+i;
    }
    veces=0;
    
}
console.log(numeros.substring(1));
}});