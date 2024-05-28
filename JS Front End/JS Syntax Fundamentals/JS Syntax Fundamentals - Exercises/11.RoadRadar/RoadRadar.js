function drive(km, area) {
  let status = '';
  let limit = 0;
  switch (area) {
    case 'motorway':
      limit = 130;
      break;
    case 'interstate':
      limit = 90;
      break;
    case 'city':
      limit = 50;
      break;
    case 'residential':
      limit = 20;
      break;
  }
  if (km <= limit) {
    console.log(`Driving ${km} km/h in a ${limit} zone`);
  } else {
    let diff = km - limit;
    if (diff<=20) {
      status = 'speeding';
    } else if(diff<=40){
      status = 'excessive speeding';
    } else {
      status = 'reckless driving';
    }
    console.log(`The speed is ${diff} km/h faster than the allowed speed of ${limit} - ${status}`);
  }
}