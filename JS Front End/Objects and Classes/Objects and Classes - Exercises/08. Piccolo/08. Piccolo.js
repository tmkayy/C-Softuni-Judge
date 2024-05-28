function park(commands) {
  let parking = []
  for (let i = 0; i < commands.length; i++) {
    let current = commands[i].split(', ');
    if (current[0]==='IN' && !parking.includes(current[1])) {
      parking.push(current[1]);
    }else if(current[0]==='OUT' && parking.includes(current[1])){
      parking = parking.filter(x=>x!==current[1]);
    }
  }
  if (parking.length===0) {
    console.log("Parking Lot is Empty");
  }else{
  parking.sort((a, b) => a.localeCompare(b)).forEach(x=>console.log(x));
  }
}