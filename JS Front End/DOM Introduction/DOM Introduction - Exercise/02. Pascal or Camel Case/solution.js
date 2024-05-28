function solve() {
  const text = document.getElementById('text');
  const com = document.getElementById('naming-convention');
  let smth = text.value.toLowerCase().split(' ');
  switch (com.value) {
    case 'Camel Case':
      morph(smth, 1);
      break;
    case 'Pascal Case':
      morph(smth, 0);
      break;
    default:
      smth = ['Error!', ''];
      break;
  }

  const r = document.getElementById('result');
  r.textContent = smth.join('');

  function morph(smth, num) {
    for (let i = num; i < smth.length; i++) {
      let temp = smth[i];
      smth[i] = temp[0].toUpperCase() + temp.substring(1);
    }
  }
}