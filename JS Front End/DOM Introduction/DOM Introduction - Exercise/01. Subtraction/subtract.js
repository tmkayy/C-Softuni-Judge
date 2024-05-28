function subtract() {
    const n1 = document.getElementById('firstNumber');
    const n2 = document.getElementById('secondNumber');
    const result = document.getElementById('result');
    result.textContent = Number(n1.value)-Number(n2.value);
}