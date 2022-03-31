function weightedRandom(base, numDivs){
var weights = []; 
var lookupTable = []; 
for (let p = 0; p < numDivs; p++){
    weights.push(Math.pow(base, p))

}

weights.forEach(function(weight, index){
for (let i = 0; i < weight; i++) {
    lookupTable.push(index); 
    }
}); 
    return function(){
return lookupTable[Math.floor(Math.random() * lookupTable.length)]; 
    }
}

let x = weightedRandom(1.5, 10); 
x(); 