function same(num) {
  let ok = true;
  let sum = 0;
  let text = num.toString();
  for (let i = 0; i < text.length; i++) {
    if (i != text.length - 1) {
      if (text[i] !== text[i + 1]) {
        ok = false;
      }
    }
    sum += Number(text[i]);
  }
  console.log(ok);
  console.log(sum);
}