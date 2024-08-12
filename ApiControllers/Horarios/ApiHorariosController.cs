﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Inscripciones.Models;
using Inscripciones.Models.Horarios;
using Inscripciones.DataContext;


namespace Inscripciones.ApiControllers.Horarios
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiHorariosController : ControllerBase
    {
        private readonly InscripcionesContext _context;

        public ApiHorariosController(InscripcionesContext context)
        {
            _context = context;
        }

        // GET: api/ApiHorarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Horario>>> Gethorarios([FromQuery]int? idCicloLectivo, int? idCarrera, int? idAnioCarrera)
        {
            if (idAnioCarrera != null && idCicloLectivo!=null)
            {
                return await _context.horarios.Include(h=>h.DetallesHorario).ThenInclude(d=>d.Hora).Include(h => h.Materia).ThenInclude(m => m.AnioCarrera).ThenInclude(a => a.Carrera).Where(h => h.Materia.AnioCarreraId.Equals(idAnioCarrera)&&h.CicloLectivoId.Equals(idCicloLectivo)).ToListAsync();
            }
            else
            {
                if (idCarrera != null && idCicloLectivo != null)
                {
                    return await _context.horarios.Include(h => h.DetallesHorario).ThenInclude(d => d.Hora).Include(h => h.Materia).ThenInclude(m => m.AnioCarrera).ThenInclude(a => a.Carrera).Where(h => h.Materia.AnioCarrera.CarreraId.Equals(idCarrera) && h.CicloLectivoId.Equals(idCicloLectivo)).ToListAsync();
                }
                else
                {
                    if(idCicloLectivo != null)
                    {
                        return await _context.horarios.Include(h => h.DetallesHorario).ThenInclude(d => d.Hora).Include(h => h.Materia).ThenInclude(m => m.AnioCarrera).ThenInclude(a => a.Carrera).Where(h => h.CicloLectivoId.Equals(idCicloLectivo)).ToListAsync();
                    }
                }    
            }
                
            return await _context.horarios.ToListAsync();
        }

        // GET: api/ApiHorarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Horario>> GetHorario(int id)
        {
            var horario = await _context.horarios.FindAsync(id);

            if (horario == null)
            {
                return NotFound();
            }

            return horario;
        }

        // PUT: api/ApiHorarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHorario(int id, Horario horario)
        {
            if (id != horario.Id)
            {
                return BadRequest();
            }

            _context.Entry(horario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HorarioExists(id))
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

        // POST: api/ApiHorarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Horario>> PostHorario(Horario horario)
        {
            _context.horarios.Add(horario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHorario", new { id = horario.Id }, horario);
        }

        // DELETE: api/ApiHorarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHorario(int id)
        {
            var horario = await _context.horarios.FindAsync(id);
            if (horario == null)
            {
                return NotFound();
            }

            _context.horarios.Remove(horario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HorarioExists(int id)
        {
            return _context.horarios.Any(e => e.Id == id);
        }
    }
}
