function validate(s) {
  let valid = true;
  if (!(s.length >= 6 && s.length <= 10)) {
    console.log("Password must be between 6 and 10 characters");
    valid = false;
  }
  if (/^[\w\d]+$/g.test(s)===false) {
    console.log("Password must consist only of letters and digits"); valid = false;
  }
  if (/\d.*\d/g.test(s)===false) {
    console.log("Password must have at least 2 digits"); valid = false;
  }
  if (valid) {
    console.log("Password is valid");
  }
}