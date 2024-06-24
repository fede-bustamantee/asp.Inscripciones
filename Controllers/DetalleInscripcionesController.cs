using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Inscripciones.Models;

namespace Inscripciones.Controllers
{
    public class DetalleInscripcionesController : Controller
    {
        private readonly InscripcionesContext _context;

        public DetalleInscripcionesController(InscripcionesContext context)
        {
            _context = context;
        }

        // GET: DetalleInscripciones
        public async Task<IActionResult> Index()
        {
            var inscripcionesContext = _context.detalleInscripcion.Include(d => d.Inscripcion).
                ThenInclude(d=>d.Alumno).Include(d => d.Materia);
            return View(await inscripcionesContext.ToListAsync());
        }

        // GET: DetalleInscripciones
        public async Task<IActionResult> IndexPorInscripcion(int? idinscripcion = 1)
        {
            var inscripcionesContext = _context.detalleInscripcion.Include(d => d.Materia).ThenInclude(m => m.AnioCarrera).ThenInclude(a => a.Carrera).Where(d => d.InscripcionId.Equals(idinscripcion)).OrderBy(d => d.Materia.AnioCarreraId);
            ViewData["Inscripciones"] = new SelectList(_context.inscripcion.Include(i => i.Alumno), "Id", "Inscripto", idinscripcion);
            ViewData["IdInscripcion"] = idinscripcion;
            return View(await inscripcionesContext.ToListAsync());
        }

        // GET: DetalleInscripciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleInscripcion = await _context.detalleInscripcion
                .Include(d => d.Inscripcion)
                .Include(d => d.Materia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleInscripcion == null)
            {
                return NotFound();
            }

            return View(detalleInscripcion);
        }

        // GET: DetalleInscripciones/Create
        public IActionResult Create()
        {
            ViewData["Inscripciones"] = new SelectList(_context.inscripcion.Include(i=>i.Alumno), "Id","Inscripto");
            ViewData["Materias"] = new SelectList(_context.materia, "Id", "Nombre");
            return View();
        }

        // POST: DetalleInscripciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ModalidadCursado,InscripcionId,MateriaId")] DetalleInscripcion detalleInscripcion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleInscripcion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InscripcionId"] = new SelectList(_context.inscripcion, "Id", "Id", detalleInscripcion.InscripcionId);
            ViewData["MateriaId"] = new SelectList(_context.materia, "Id", "Id", detalleInscripcion.MateriaId);
            return View(detalleInscripcion);
        }

        // GET: DetalleInscripciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleInscripcion = await _context.detalleInscripcion.FindAsync(id);
            if (detalleInscripcion == null)
            {
                return NotFound();
            }
            ViewData["Inscripciones"] = new SelectList(_context.inscripcion, "Id", "Fecha", detalleInscripcion.InscripcionId);
            ViewData["Materias"] = new SelectList(_context.materia, "Id", "Nombre", detalleInscripcion.MateriaId);
            return View(detalleInscripcion);
        }

        // POST: DetalleInscripciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ModalidadCursado,InscripcionId,MateriaId")] DetalleInscripcion detalleInscripcion)
        {
            if (id != detalleInscripcion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleInscripcion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleInscripcionExists(detalleInscripcion.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["InscripcionId"] = new SelectList(_context.inscripcion, "Id", "Id", detalleInscripcion.InscripcionId);
            ViewData["MateriaId"] = new SelectList(_context.materia, "Id", "Id", detalleInscripcion.MateriaId);
            return View(detalleInscripcion);
        }

        // GET: DetalleInscripciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleInscripcion = await _context.detalleInscripcion
                .Include(d => d.Inscripcion)
                .Include(d => d.Materia)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detalleInscripcion == null)
            {
                return NotFound();
            }

            return View(detalleInscripcion);
        }

        // POST: DetalleInscripciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalleInscripcion = await _context.detalleInscripcion.FindAsync(id);
            if (detalleInscripcion != null)
            {
                _context.detalleInscripcion.Remove(detalleInscripcion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleInscripcionExists(int id)
        {
            return _context.detalleInscripcion.Any(e => e.Id == id);
        }
    }
}
