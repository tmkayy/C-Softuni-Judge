function cook(num, o1, o2, o3, o4, o5) {
  num = operation(num, o1);
  num = operation(num, o2);
  num = operation(num, o3);
  num = operation(num, o4);
  num = operation(num, o5);

  function operation(num, op) {
    switch (op) {
      case 'chop':
        num /= 2;
        break;
      case 'dice':
        num = Math.sqrt(num);
        break;
      case 'spice':
        num += 1;
        break;
      case 'bake':
        num *= 3;
        break;
      case 'fillet':
        num *= 0.8;
        break;
    }
    console.log(num);
    return num;
  }  
}