function employees (arr)
{
  let emps = [];
  for (const iterator of arr) {
    emps.push({name: iterator, num: iterator.length})
  }
  emps.forEach(x=>console.log(`Name: ${x.name} -- Personal Number: ${x.num}`))
}