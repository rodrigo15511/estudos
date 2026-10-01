using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaEscolarAPI.Models;
using SistemaEscolarAPI.DTO;
using SistemaEscolarAPI.DB;
using Microsoft.EntityFrameworkCore;
namespace SistemaEscolarAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisciplinaAlunoCursoController
    {
        private readonly AppDbContext _context;
        public DisciplinaAlunoCursoController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DisciplinaAlunoCursoDTO>>> Get()
        {
            var disciplinas = await _context.DisciplinasAlunosCursos
                .Select(disciplina => new DisciplinaAlunoCursoDTO { Descricao = disciplina.Descricao })
                .ToListAsync();

            return Ok(disciplinas);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DisciplinaAlunoCursoDTO disciplinaDTO)
        {
            var disciplina = new DisciplinaAlunoCurso { Descricao = disciplinaDTO.Descricao };
            _context.DisciplinasAlunosCursos.Add(disciplina);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] DisciplinaAlunoCursoDTO disciplinaDTO)
        {
            var disciplina = await _context.DisciplinasAlunosCursos.FindAsync(id);
            if (disciplina == null) return NotFound("Disciplina não encontrada.");

            disciplina.Descricao = disciplinaDTO.Descricao;

            _context.DisciplinasAlunosCursos.Update(disciplina);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var disciplina = await _context.DisciplinasAlunosCursos.FindAsync(id);
            if (disciplina == null) return NotFound("Disciplina nao encontrada.");
            _context.DisciplinasAlunosCursos.Remove(disciplina);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}