using Microsoft.AspNetCore.Mvc;  

[ApiController]
[Route("api/contacts/")]
public class ContactGetController : ControllerBase {
[HttpGet]
public IActionResult GetAll()
{
  var contacts = DbRequest.Get();
// le return converti automatiquement en json ce qui est envoyé au front
return Ok(contacts);
}
}