let a = +prompt(("Введите а:"));
let b = +prompt(("Введите b:"));
let x = +prompt(("Введите х:"));
let y = +prompt(("Введите у:"));
let z;

if (x > 0 && y > 0) {
    let maxEl = a / x;
    if (maxEl < b / x) {
        maxEl = b / x
    }
    if (maxEl < Math.sqrt(y)) {
        maxEl = Math.sqrt(y);
    }
    z = maxEl;
} else if (x < 0 && y > 0) {
    let minEl = a * Math.pow(x, 3)
    if (minEl < b * Math.pow(y, 2))
        minEl = b * Math.pow(y, 2)
    z = minEl;
} else z = Math.pow(2, x + y);
console.log(z)
alert(z)