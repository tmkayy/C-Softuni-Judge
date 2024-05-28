function weirdSort(arr) {
  let arr2 = [];
  arr.sort((a, b) => a-b);
  while (true) {
    arr2.push(arr.shift());
    arr2.push(arr.pop());
    if (arr.length == 0) {
      break;
    }
  }
  return arr2;
}