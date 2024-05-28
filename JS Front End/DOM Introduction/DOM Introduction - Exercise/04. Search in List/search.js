function search() {
   const word = document.getElementById('searchText');
   let ws = word.value;
   const list = Array.from(document.querySelector('#towns').children);
   let cnt = 0;
   for (let i = 0; i < list.length; i++) {
      if (list[i].textContent.toLowerCase().includes(ws.toLowerCase())) {
         cnt++;
         list[i].innerHTML = `<u style = 'font-weight: bold'>${list[i].textContent}</u>`;
      }
   }
   const r = document.querySelector('#result');
   r.textContent = `${cnt} matches found`;
}
