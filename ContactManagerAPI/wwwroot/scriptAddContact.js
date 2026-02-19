export let user = document.querySelector("#name");
export let num = document.querySelector("#num");
let btnAdd = document.querySelector("#btnAdd");

btnAdd.addEventListener("click", async function (e) {
  let contact = {
    name: user.value,
    num: num.value,
  };
  console.log(contact);
  try {
    const reponse = await fetch("http://localhost:5054/api/contacts", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(contact),
    });
    let data = await reponse.json();
    if (reponse.ok) {
      alert(data.message);
    } else {
      alert("Erreur serveur");
    }
  } catch (error) {
    console.log("erreur fetch method POST");
  }
  num.value = "";
  user.value = "";
});
