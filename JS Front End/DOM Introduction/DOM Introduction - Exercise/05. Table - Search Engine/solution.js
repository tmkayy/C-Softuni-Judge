function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const rows = Array.from(document.querySelectorAll('tbody tr'));
      const search = document.getElementById('searchField');
      const word = search.value.toLowerCase();
      search.value = '';
      for (let i = 0; i < rows.length; i++) {
         rows[i].classList.remove('select');
         const row = Array.from(rows[i].children);
         for (let j = 0; j < row.length; j++) {
            if (row[j].textContent.toLowerCase().includes(word)) {
               rows[i].classList.add('select');
            }
         }
      }
   }
}