using Microsoft.AspNetCore.Mvc;  

[ApiController]
[Route("api/contacts/")]
public class ContactDelController : ControllerBase{
  // le parametre dynamique se met dans l'attribut http
  [HttpDelete("{name}")]
  // si la valeur vient de l'url on met FromRoute
  public IActionResult Delete([FromRoute] string name){
    DbRequest.Delete( name);
    Console.WriteLine($"delete to db {name}");
return Ok(new { message = "Contact supprimé", name });
  }
}