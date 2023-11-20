
using Microsoft.AspNetCore.Mvc;
using TESTE.Data;
using TESTE.models;

namespace TESTE.Controllers{

[ApiController]
[Route("api/cliente")]
public class ClienteController : ControllerBase
{
    private readonly AppDataContext _context;
    public ClienteController(AppDataContext context)
    {
    _context = context;
    }


[HttpGet]
[Route("listar")]
public IActionResult Listar()
{
    try
    {
        List<Cliente> clientes = _context.Clientes.ToList();
        return Ok(clientes);
    }
    catch (Exception e)
    {
        return BadRequest(e.Message);
    }
}

[HttpPost]
[Route("cadastrar")]
public IActionResult Cadastrar([FromBody] Cliente cliente)
{
    try
    {
        _context.Clientes.Add(cliente);
        _context.SaveChanges();
        return Created("", cliente);
    }
    catch (Exception e) 
    {
        Console.WriteLine(e);
        return BadRequest(e.Message);
    }
}
}
}
