using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaEscolarAPI.Models;
using SistemaEscolarAPI.DTO;
using SistemaEscolarAPI.DB;
using Microsoft.AspNetCore.Mvc;


namespace SistemaEscolarAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisciplinaController
    {
        private readonly AppDbContext _context;

        public DisciplinaController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DisciplinaDTO>>> Get()
        {
            var disciplinas = await _context.DisciplinasAlunosCursos
                .Select(disciplina => new DisciplinaDTO { Descricao = disciplina.Descricao, Curso = disciplina.Curso })
                .ToListAsync();
                
            return Ok(disciplinas);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DisciplinaDTO disciplinaDTO)
        {
            var disciplina = new DisciplinaAlunoCurso { Descricao = disciplinaDTO.Descricao, Curso = disciplinaDTO.Curso };
            _context.DisciplinasAlunosCursos.Add(disciplina);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] DisciplinaDTO disciplinaDTO)
        {
            var disciplina = await _context.DisciplinasAlunosCursos.FindAsync(id);
            if (disciplina == null) return NotFound("Disciplina não encontrada.");

            disciplina.Descricao = disciplinaDTO.Descricao;
            disciplina.Curso = disciplinaDTO.Curso;

            _context.DisciplinasAlunosCursos.Update(disciplina);
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var disciplina = await _context.DisciplinasAlunosCursos.FindAsync(id);
            if (disciplina == null) return NotFound("Disciplina não encontrada.");

            _context.DisciplinasAlunosCursos.Remove(disciplina);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}