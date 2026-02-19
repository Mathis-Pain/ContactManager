using Microsoft.AspNetCore.Mvc;  


[ApiController]
[Route("api/contacts")]
public class ContactPostController : ControllerBase{
  [HttpPost]
  public IActionResult Add([FromBody] Contact contact){
    DbRequest.Post( contact.name, contact.num);
    Console.WriteLine($"add to db {contact.name}: {contact.num}");
return Ok(new { message = "Contact ajouté", contact });
  }
}
