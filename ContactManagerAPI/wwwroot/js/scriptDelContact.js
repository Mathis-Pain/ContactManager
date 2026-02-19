import {user} from './scriptAddContact.js'
let btnDel = document.querySelector('#btnDel')

btnDel.addEventListener('click', async () => {
  try {
    const reponse = await fetch(
      `http://localhost:5054/api/contacts/${user.value}`,
      {
        method: 'DELETE'
      }
    )
    let data = await reponse.json()
    if (reponse.ok) {
      alert(data.message)
    } else {
      alert('Erreur serveur')
    }
  } catch (error) {
    console.log('erreur fetch method Delete')
  }
})
