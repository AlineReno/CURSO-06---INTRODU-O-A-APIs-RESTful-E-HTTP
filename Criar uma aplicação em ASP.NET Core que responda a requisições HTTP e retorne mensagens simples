using FilmesAPI.Controllers;
using FilmesAPI.Controllers.Models.FilmesAPI.Models;
using FilmesAPI.Controllers.NovaPasta.NovaPasta;
using FilmesAPI.Data;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using static System.Net.WebRequestMethods;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
    private FilmeContext _context;

        public FilmeController(FilmeContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionaFilme([Frombody] CreatFilmeDto filmeDto)
        {
            Filme filme = new Filme
            {
                Titulo = filmeDto.Titulo,
                Genero = filmeDto.Genero,
                Duracao = filmeDto.Duracao,
                Diretor = filmeDto.Diretor,
            };
            object value = _context.Filmes.Add(filme);
            _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarFilmesPorId), new { Id = filme.Id }, filme);
        }

        [HttpGet]
        public IActionResult RecuperarFilmes()
        {
            return Ok(_context.Filmes);
        }

        [HttpGet("(id)")]
        public IActionResult RecuperarFilmesPorId(int id)
        {

            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme != null)
            {
                return Ok(filme);
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if(filme == null)
            {
                return NotFound();
            }
            filme.Titulo = filmeDto.Titulo;
            filme.Genero = filmeDto.Genero;
            filme.Duracao = filmeDto.Duracao;
            filme.Diretor = filmeDto.Diretor;
            _context.SaveChanges();
            return NoContent();
        }
            [HttpDelete("{id}")]
                 public IActionResult DeletaFilme(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme == null)
            {
                return NotFound();
            }
            _context.Remove(filme);
            _context.SaveChanges();
            return NoContent();
        }
                    }
        }

