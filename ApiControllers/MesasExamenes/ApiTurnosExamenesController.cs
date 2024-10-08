﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Inscripciones.Models;
using Inscripciones.DataContext;


namespace Inscripciones.ApiControllers.MesasExamenes
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiTurnosExamenesController : ControllerBase
    {
        private readonly InscripcionesContext _context;

        public ApiTurnosExamenesController(InscripcionesContext context)
        {
            _context = context;
        }

        // GET: api/ApiTurnosExamenes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TurnoExamen>>> Getturnosexamenes()
        {
            return await _context.turnosexamenes.ToListAsync();
        }

        // GET: api/ApiTurnosExamenes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TurnoExamen>> GetTurnoExamen(int id)
        {
            var turnoExamen = await _context.turnosexamenes.FindAsync(id);

            if (turnoExamen == null)
            {
                return NotFound();
            }

            return turnoExamen;
        }

        // PUT: api/ApiTurnosExamenes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTurnoExamen(int id, TurnoExamen turnoExamen)
        {
            if (id != turnoExamen.Id)
            {
                return BadRequest();
            }

            _context.Entry(turnoExamen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TurnoExamenExists(id))
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

        // POST: api/ApiTurnosExamenes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TurnoExamen>> PostTurnoExamen(TurnoExamen turnoExamen)
        {
            _context.turnosexamenes.Add(turnoExamen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTurnoExamen", new { id = turnoExamen.Id }, turnoExamen);
        }

        // DELETE: api/ApiTurnosExamenes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTurnoExamen(int id)
        {
            var turnoExamen = await _context.turnosexamenes.FindAsync(id);
            if (turnoExamen == null)
            {
                return NotFound();
            }

            _context.turnosexamenes.Remove(turnoExamen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TurnoExamenExists(int id)
        {
            return _context.turnosexamenes.Any(e => e.Id == id);
        }
    }
}
