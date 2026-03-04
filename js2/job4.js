
function Name(a,b,c){
    let La = Math.sqrt(b * c * Math.pow(b + c, 2) - Math.pow(a, 2)) / (b + c);
    return La;
}
let a =4;
let b =6;
let c =5;
let result = Name(a,b,c);
console.log(result);