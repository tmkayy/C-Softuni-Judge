function solve() {
  const input = document.getElementById('input');
  let sentences = Array.of(input.value.split('.'));
  let formated = [];
  let temp = [];
  for (let i = 0; i < sentences.length; i++) {
    if (i%3===0&&i!==0) {
      formated.push(`<p>${temp.join('.')}</p>`)
      temp = [];
    }
    temp.push(sentences[i]);
  }
  if (temp.length<3) {
    formated.push(`<p>${temp.join('.')}</p>`)
  }
  document.getElementById('output').innerHTML = formated.join('.');
}