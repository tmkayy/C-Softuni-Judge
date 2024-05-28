function toggle() {
    const but = document.querySelector('.head .button');
    const sextra = document.getElementById('extra');
    if (but.textContent==='More') {
        sextra.style.display = 'block';
        but.textContent = 'Less';
    }else {
        sextra.style.display = 'none';
        but.textContent='More';
    }
}