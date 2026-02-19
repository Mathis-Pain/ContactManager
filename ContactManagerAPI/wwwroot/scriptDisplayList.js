let displayList = document.querySelector('#output')

window.addEventListener('DOMContentLoaded', async () => {
  try {
    const reponse = await fetch('api/contacts/')
    const contacts = await reponse.json()
    displayList.innerHTML = ''
    contacts.forEach((contact) => {
      displayList.innerHTML += `<p>${contact.name} : ${contact.num}</p>`
    })
  } catch (error) {
    console.log('erreur lors du fetch get en db')
  }
})
