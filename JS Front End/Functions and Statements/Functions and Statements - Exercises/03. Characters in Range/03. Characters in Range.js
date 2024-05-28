function between(c1, c2) {
  let arr = []
  if (c1.charCodeAt(0) < c2.charCodeAt(0)) {
    for (let i = c1.charCodeAt(0)+1; i < c2.charCodeAt(0); i++) {
      arr.push(String.fromCharCode(i));
    }
  }
  else {
    for (let i = c2.charCodeAt(0)+1; i < c1.charCodeAt(0); i++) {
      arr.push(String.fromCharCode(i));
    }
  }
  console.log(arr.join(' '));
}