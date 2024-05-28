function search (word, text){
  const r = new RegExp(`\\b${word}\\b`, 'i');
  if (r.test(text)) {
    console.log(word);
  }
  else{
    console.log(`${word} not found!`);
  }
}