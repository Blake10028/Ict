function validateForm() {
//x will be the user name if he dont put someti=hing in the text boxa alert should come out
var x = document.forms["myForm"]["fullname"].value;
if (x == "") {
alert("Name must be filled out");
return false;
}
//y will be the user email if he dont put someti=hing in the text box a alert should come out
var y = document.forms["myForm"]["email"].value;
if (y == "") {
alert("Email must be filled out");
return false;
}

}