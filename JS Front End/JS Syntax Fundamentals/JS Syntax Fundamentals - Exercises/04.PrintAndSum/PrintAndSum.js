function ps(n1, n2) {
  let sum = 0;
  let s = ``;
  for (let i = n1; i <= n2; i++) {
    s += `${i} `
    sum += i;
  }
  console.log(s);
  console.log('Sum: ' + sum)
}