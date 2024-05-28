function load(num) {
  num = num / 10;
  if (num === 10) {
    console.log('100% Complete!');
    console.log(`[%%%%%%%%%%]`);
  } else {
    console.log(`${num*10}% [${'%'.repeat(num)}${'.'.repeat(10-num)}]`);
    console.log(`Still loading...`);
  }
}