let x= +prompt("");
for (let i =-3; i<3;i+=0.25){
    if(x>2){
        x= Math.pow(Math.E,2);
    }else if (i>=-2 && i<=2){
        x=x+4;
    } else {
        x=0
    }
    console.log(x);
}
