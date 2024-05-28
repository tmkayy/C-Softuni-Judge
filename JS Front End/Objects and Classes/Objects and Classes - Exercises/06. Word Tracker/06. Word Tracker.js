function tracker(arr){
  let words = arr[0].split(' ');
  let list = [];
  let text = arr.slice(1);
  for (const word of words) {
    let count = text.filter(x=>x===word).length;
    list.push({word: word, count: count});
  }
  list.sort((a, b) => b.count-a.count);
  list.forEach(x=>console.log(`${x.word} - ${x.count}`))
}