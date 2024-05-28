function mov(commands) {
  let movies = [];
  for (let i = 0; i < commands.length; i++) {
    let currentCom = commands[i].split(' ');
    for (let j = 0; j < currentCom.length; j++) {
      let temp = [];
      switch (currentCom[j]) {
        case 'addMovie':
          temp = commands[i].split('addMovie ');
          movies.push({ name: temp[1]});
          break;
        case 'directedBy':
          temp = commands[i].split(' directedBy ');
          let finder = movies.findIndex(x=>x.name===temp[0]);
          if (finder!=-1) {
            movies[finder].director = temp[1];
          }
          break;
        case 'onDate':
          temp = commands[i].split(' onDate ');
          let finder2 = movies.findIndex(x=>x.name===temp[0]);
          if (finder2!=-1) {
            movies[finder2].date = temp[1];
          }
          break;
      }
    }
  }
  movies.filter(x=>x.name&&x.director&&x.date).forEach(x=>console.log(JSON.stringify(x)))
}