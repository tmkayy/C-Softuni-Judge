function oddeven(num) {
  let sum1 = 0;
  let sum2 = 0
  while (num!=0) {
    if (num%10%2==1) {
      sum1+=num%10;
    }else{
      sum2+=num%10;
    }
    num=Math.floor(num/10)
  }
  console.log(`Odd sum = ${sum1}, Even sum = ${sum2}`);
}