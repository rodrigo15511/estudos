using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaEscolarAPI.Models;
using SistemaEscolarAPI.DTO;
using SistemaEscolarAPI.DB;

namespace SistemaEscolarAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CursoController
    {
        private readonly AppDbContext _context;

        public CursoController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursoDTO>>> Get()
        {
            var cursos = await _context.Cursos
                .Select(cursoS => new CursoDTO { Descricao = curso.Descricao })
                .ToListAsync();

            return Ok(cursos);
        }
        [HttpPost]

        public async Task<ActionResult> Post([FromBody] CursoDTO cursoDTO)
        {
            var curso = new Curso { Descricao = cursoDTO.Descricao };
            _context.Cursos.Add(curso);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CursoDTO cursoDTO)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null) return NotFound("Curso não encontrado.");
            

            curso.Descricao = cursoDTO.Descricao;

            _context.Cursos.Update(curso);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
            {
                var curso = await _context.Cursos.FindAsync(id); // Procura o curso pelo ID

                if (curso == null)
                return NotFound("Curso não encontrado"); // Se não encontrar, retorna 404

                _context.Cursos.Remove(curso); // Remove o curso do contexto
                await _context.SaveChangesAsync(); // Salva as alterações no banco de dados

                return NoContent(); // Retorna status 204 No Content
}

    }
}