using Microsoft.AspNetCore.Mvc;  

[ApiController]
[Route("api/contacts")]
public class ContactController : ControllerBase{
  [HttpPost]
  public IActionResult Add([FromBody] Contact contact){
    DbRequest.Post( contact.name, contact.num);
    Console.WriteLine($"add to db {contact}");
return Ok();
  }
}