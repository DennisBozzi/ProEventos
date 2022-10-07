using Microsoft.AspNetCore.Mvc;

namespace ProEventos.API.Models;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[] {
        new Evento() {
            EventoId = 1,
            Tema = "Angular e .NET Core",
            Local = "Belo Horizonte",
            Lote = "1 Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yy"),
            ImagemUrl = "foto.png"
        },

        new Evento() {
            EventoId = 2,
            Tema = "Angular e suas novidades",
            Local = "Sao Paulo",
            Lote = "2 Lote",
            QtdPessoas = 350,
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            ImagemUrl = "print.png"
        }
    };

    public EventoController()
    {
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost]

    public String Post()
    {
        return "Metodo Post";
    }

    [HttpDelete]

    public String Delete(int id)
    {
        return $"Exemplo de Delete com id = {id}";
    }

    [HttpPut]

    public String Put(int id)
    {
        return $"Exemplo de Put com id = {id}";
    }

}
