function factDiv(n1, n2){
  let f1 = 1;
  let f2 = 1;
  for (let i = 1; i <= n1; i++) {
    f1*=i;
  }
  for (let i = 1; i <= n2; i++) {
    f2*=i;
  }
  console.log((f1/f2).toFixed(2));
}
