function sumdig (num) {
  let sum = 0;
  while (true) {
    if (num==0) {
      break;
    }
    sum+=num%10;
    num = Math.trunc(num/10);
  }
  console.log(sum);
}