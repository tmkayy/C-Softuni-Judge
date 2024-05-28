function oddsearch(arr) {
  arr = arr.split(' ').map(x=>x = x.toLowerCase());
  let unique = finduni(arr);
  let final = [];
  for (const word of unique) {
    let count = arr.filter(x=>x===word).length;
    if (count%2==1) {
      final.push(word);
    }
  }
  console.log(final.join(' '));

  function finduni(arr) {
    let temp = [];
    for (let i = 0; i < arr.length; i++) {
      if (!temp.includes(arr[i])) {
        temp.push(arr[i])
      }
    }
    return temp;
  }
}