let user = document.querySelector("#name");
let num = document.querySelector("#num");
let btnAdd = document.querySelector("#btnAdd");

btnAdd.addEventListener("click", function (e) {
  let contact = {
    name: user.value,
    num: num.value,
  };
  console.log(contact);
  num.value = "";
  user.value = "";
});
