function dick(arr) {
  let dic = {};
  for (const thing of arr) {
    let temp = JSON.parse(thing);
    for (const key in temp) {
      dic[key] = temp[key];
    }
  }
  Object.entries(dic).sort((a, b)=>a[0].localeCompare(b[0])).forEach(x => {
    console.log(`Term: ${x[0]} => Definition: ${x[1]}`);
  });
}