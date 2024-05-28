// i hope whoever made this dies in a car crash
function reveal(words, text) {
  words = words.split(', ');
  let r = new RegExp(`[*]+`, 'g');
  const matches = text.matchAll(r);
  for (const match of matches) {
    const word = words.find(x=>x.length===match[0].length)
    text = text.replace(match[0], word)
  }
  console.log(text);
}