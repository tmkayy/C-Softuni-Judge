function imsodone(s){
  const r = new RegExp('#([A-Za-z]+)', 'g')
  const array = [...s.matchAll(r)];
  for (const x of array) {
    console.log(x[1]);
  }
}