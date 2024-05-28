function fruitprice (fruit, g, ppkg) {
  console.log(`I need \$${((g/1000)*ppkg).toFixed(2)} to buy ${(g/1000).toFixed(2)} kilograms ${fruit}.`);
}