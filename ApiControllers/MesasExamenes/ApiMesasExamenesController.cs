﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Inscripciones.Models;
using Inscripciones.Models.MesasExamenes;
using Inscripciones.DataContext;


namespace Inscripciones.ApiControllers.MesasExamenes
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiMesasExamenesController : ControllerBase
    {
        private readonly InscripcionesContext _context;

        public ApiMesasExamenesController(InscripcionesContext context)
        {
            _context = context;
        }

        // GET: api/ApiMesasExamenes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MesaExamen>>> Getmesasexamenes([FromQuery] int? idCarrera, int? idTurno)
        {
            if (idCarrera != null && idTurno != null)
            {
                return await _context.mesasexamenes.Include(m => m.DetallesMesaExamen).ThenInclude(d => d.Docente).Include(m => m.Materia).ThenInclude(m => m.AnioCarrera).ThenInclude(a => a.Carrera).Where(m => m.Materia.AnioCarrera.CarreraId == idCarrera && m.TurnoExamenId == idTurno).ToListAsync();
            }
            return await _context.mesasexamenes.ToListAsync();
        }

        // GET: api/ApiMesasExamenes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MesaExamen>> GetMesaExamen(int id)
        {
            var mesaExamen = await _context.mesasexamenes.FindAsync(id);

            if (mesaExamen == null)
            {
                return NotFound();
            }

            return mesaExamen;
        }

        // PUT: api/ApiMesasExamenes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMesaExamen(int id, MesaExamen mesaExamen)
        {
            if (id != mesaExamen.Id)
            {
                return BadRequest();
            }

            _context.Entry(mesaExamen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MesaExamenExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ApiMesasExamenes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MesaExamen>> PostMesaExamen(MesaExamen mesaExamen)
        {
            _context.mesasexamenes.Add(mesaExamen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMesaExamen", new { id = mesaExamen.Id }, mesaExamen);
        }

        // DELETE: api/ApiMesasExamenes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMesaExamen(int id)
        {
            var mesaExamen = await _context.mesasexamenes.FindAsync(id);
            if (mesaExamen == null)
            {
                return NotFound();
            }

            _context.mesasexamenes.Remove(mesaExamen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MesaExamenExists(int id)
        {
            return _context.mesasexamenes.Any(e => e.Id == id);
        }
    }
}
