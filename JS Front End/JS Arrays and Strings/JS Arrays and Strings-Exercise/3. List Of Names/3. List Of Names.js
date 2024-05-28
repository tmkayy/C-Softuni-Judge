function sort(arr) {
  arr.sort((a, b) => a.localeCompare(b));
  let i = 1;
  for (x of arr) {
    console.log(`${i}.` + `${x}`);
    i++;
  }
} 