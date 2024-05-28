function stats (heroes){
  let hs =[]
  for (const h of heroes) {
    let data = h.split(' / ')
    hs.push({hero: data[0], level: Number(data[1]), items: data[2]})
  }
  hs.sort((x1, x2) => x1.level - x2.level).forEach(x=>console.log(`Hero: ${x.hero}\nlevel => ${x.level}\nitems => ${x.items}`))
}