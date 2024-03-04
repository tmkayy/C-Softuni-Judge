function leap(num) {
  console.log((num % 4 == 0 && num % 100 != 0 || num % 400 == 0) ? 'yes' : 'no');
}