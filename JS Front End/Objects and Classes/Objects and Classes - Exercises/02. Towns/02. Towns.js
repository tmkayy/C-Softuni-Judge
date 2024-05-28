function towns(arr) {
  let towninfo = [];
  for (const iterator of arr) {
    let [name, latitude, longitude, ...elems] = iterator.split(" | ");
    towninfo.push({ town: name, latitude: Number(latitude).toFixed(2), longitude: Number(longitude).toFixed(2) })
  }
  towninfo.forEach(x => console.log(x));
}