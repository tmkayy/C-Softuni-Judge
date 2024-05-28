function print(nums) {
  nums.forEach(x => {
    console.log(palindrome(x));
  });

  function palindrome(num) {
    let s = String(num);
    for (let i = 0; i < s.length; i++) {
      if (s[i]!==s[s.length-1-i]) {
        return false;
      }
    }
    return true;
  }
}