let x = +prompt("Введите x = ");
let y = +prompt("Введите y = ");

let d =  Math.pow((y * Math.pow(x, 2) - 1), 2) / (2) * (Math.pow(Math.cos(y), 2) - Math.sin(Math.pow(x,2)));

console.log(d);