﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Inscripciones.Models;
using Inscripciones.Models.Commons;
using Inscripciones.DataContext;


namespace Inscripciones.ApiControllers.Commons
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiInscriptosCarrerasController : ControllerBase
    {
        private readonly InscripcionesContext _context;

        public ApiInscriptosCarrerasController(InscripcionesContext context)
        {
            _context = context;
        }

        // GET: api/ApiInscriptosCarreras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InscriptoCarrera>>> Getinscriptoscarreras()
        {
            return await _context.inscriptoscarreras.ToListAsync();
        }

        // GET: api/ApiInscriptosCarreras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InscriptoCarrera>> GetInscriptoCarrera(int id)
        {
            var inscriptoCarrera = await _context.inscriptoscarreras.FindAsync(id);

            if (inscriptoCarrera == null)
            {
                return NotFound();
            }

            return inscriptoCarrera;
        }

        // PUT: api/ApiInscriptosCarreras/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInscriptoCarrera(int id, InscriptoCarrera inscriptoCarrera)
        {
            if (id != inscriptoCarrera.Id)
            {
                return BadRequest();
            }

            _context.Entry(inscriptoCarrera).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InscriptoCarreraExists(id))
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

        // POST: api/ApiInscriptosCarreras
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InscriptoCarrera>> PostInscriptoCarrera(InscriptoCarrera inscriptoCarrera)
        {
            _context.inscriptoscarreras.Add(inscriptoCarrera);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInscriptoCarrera", new { id = inscriptoCarrera.Id }, inscriptoCarrera);
        }

        // DELETE: api/ApiInscriptosCarreras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInscriptoCarrera(int id)
        {
            var inscriptoCarrera = await _context.inscriptoscarreras.FindAsync(id);
            if (inscriptoCarrera == null)
            {
                return NotFound();
            }

            _context.inscriptoscarreras.Remove(inscriptoCarrera);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InscriptoCarreraExists(int id)
        {
            return _context.inscriptoscarreras.Any(e => e.Id == id);
        }
    }
}
