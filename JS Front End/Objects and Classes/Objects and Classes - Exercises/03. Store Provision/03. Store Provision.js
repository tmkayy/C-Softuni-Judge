function store(arr, arr2) {
  let finalproducts = [];
  for (let i = 0; i < arr.length; i += 2) {
    finalproducts.push({ name: arr[i], quantity: Number(arr[i + 1]) });
  }
  for (let i = 0; i < arr2.length; i += 2) {
    let productIndex = finalproducts.findIndex(x => x.name === arr2[i]);
    if (productIndex !== -1) {
      finalproducts[productIndex].quantity += Number(arr2[i + 1]);
    }
    else {
      finalproducts.push({ name: arr2[i], quantity: Number(arr2[i + 1]) });
    }
  }
  finalproducts.forEach(x=>console.log(`${x.name} -> ${x.quantity}`));
}