using Microsoft.AspNetCore.Mvc;
using Prova.Models;
namespace Prova.Controllers;

[ApiController] 
public class ProvaController : ControllerBase
{

    static List<User> lista = new List<User>();

    [HttpGet] 
    [Route("user")]
    public ActionResult Read() 
    {
        return Ok(lista);   
    }
    [HttpGet] 
    [Route("login")]
    public ActionResult Read(string email, string password)
    {
        foreach (User user in lista)
        {
            if(user.Email == email)
            {
                if(user.Password == password)
                {
                    return Ok(user);
                }           
            }
        }
        return NotFound();
    }

    [HttpPost]
    [Route("user")] 
    public ActionResult Create(User usuario) 
    {
        lista.Add(usuario);
        return Created("", usuario);
    }

   


}

