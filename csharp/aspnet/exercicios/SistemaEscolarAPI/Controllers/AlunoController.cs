using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaEscolarAPI.Models;
using SistemaEscolarAPI.DTO;
using Microsoft.AspNetCore.Mvc;

namespace SistemaEscolarAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly AppContext _context;

        public AlunoController(AppContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlunoDTO>>> Get()
        {
            var alunos = await _context.Alunos
                .Include(a => a.Turma)
                .Select(aluno => new AlunoDTO
                {
                    Nome = aluno.Nome,
                    Curso = aluno.Curso.Descricao
                }) // Seleciona os alunos e projeta em um DTO
                .ToListAsync(); // Converte para uma lista assíncrona

            return Ok(alunos);
        }

        [HttpPost]
        public async Task<ActionResult<AlunoDTO>> Post([FromBody] AlunoDTO alunoDTO){
            var Curso = await _context.Cursos.FirstOrDefaultAsync(c => c.Descricao == alunoDTO.Curso);
            if (Curso == null) return BadRequest("Curso nao encontrado.");

            var aluno = new Aluno { Nome = alunoDTO.Nome, CursoId = Curso.ID};
            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();

            return Ok();           
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AlunoDTO>> Put(int id, [FromBody] AlunoDTO alunoDTO)
        {
            var aluno = await _context.Alunos.FindAsync(id);

            if (aluno == null) return NotFound("Aluno não encontrado."); // erro 404
            var Curso = await _context.Cursos.FirstOrDefaultAsync(c => c.Descricao == alunoDTO.Curso);
            if (Curso == null) return BadRequest("Curso nao encontrado."); // erro 400

            aluno.Nome = alunoDTO.Nome;
            aluno.CursoId = Curso.ID;

            _context.Alunos.Update(aluno);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null) return BadRequest("Aluno não encontrado.");
            _context.Alunos.Remove(aluno);
            
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}