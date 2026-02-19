let user = document.querySelector("#name");
let num = document.querySelector("#num");
let btnAdd = document.querySelector("#btnAdd");

btnAdd.addEventListener("click", async function (e) {
  let contact = {
    name: user.value,
    num: num.value,
  };
  console.log(contact);
  try {
    const reponse = await fetch("http://localhost:5000/api/contacts", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(contact),
    });
  } catch (error) {
    console.log("erreur fetch method POST");
  }
  num.value = "";
  user.value = "";
});
