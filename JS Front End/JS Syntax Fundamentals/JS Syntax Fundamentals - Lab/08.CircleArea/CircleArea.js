function calcCircle (num){
  if(typeof(num)=='number'){
    console.log((num**2*Math.PI).toFixed(2))
  }else{
    console.log(`We can not calculate the circle area, because we receive a ${typeof(num)}.`)
  }
}