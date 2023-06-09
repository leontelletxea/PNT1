﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_basico.Context;
using MVC_basico.Models;

namespace MVC_basico.Controllers
{
    public class EntradaController : Controller
    {
        private readonly CineDatabaseContext _context;

        public EntradaController(CineDatabaseContext context)
        {
            _context = context;
        }

        // GET: Entrada
        public async Task<IActionResult> Index()
        {
              return _context.Entradas != null ? 
                          View(await _context.Entradas.ToListAsync()) :
                          Problem("Entity set 'CineDatabaseContext.Entradas'  is null.");
        }

        // GET: Entrada/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Entradas == null)
            {
                return NotFound();
            }

            var entrada = await _context.Entradas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entrada == null)
            {
                return NotFound();
            }

            return View(entrada);
        }

        // GET: Entrada/Create
        public IActionResult Create()
        {
            ViewData["Peliculas"] = new SelectList(_context.Peliculas, "titulo", "titulo");
            return View();
        }

        // POST: Entrada/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,usuario,email,pelicula,sala,fila,butaca,fecha")] Entrada entrada)
        {
            if (ModelState.IsValid)
            {
                // Verificar si la entrada ya existe en la base de datos
                bool entradaExistente = await _context.Entradas.AnyAsync(e =>
                    e.pelicula == entrada.pelicula &&
                    e.sala == entrada.sala &&
                    e.fila == entrada.fila &&
                    e.butaca == entrada.butaca &&
                    e.fecha == entrada.fecha);

                if (entradaExistente)
                {
                    ModelState.AddModelError("", "La entrada ya está reservada.");
                    ViewData["Peliculas"] = new SelectList(_context.Peliculas, "titulo", "titulo", entrada.pelicula);
                    return View(entrada);
                }

                // Si no existe, guardar la entrada en la base de datos
                _context.Add(entrada);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Peliculas"] = new SelectList(_context.Peliculas, "titulo", "titulo", entrada.pelicula);
            return View(entrada);
        }

        // GET: Entrada/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Entradas == null)
            {
                return NotFound();
            }

            var entrada = await _context.Entradas.FindAsync(id);
            if (entrada == null)
            {
                return NotFound();
            }
            ViewData["Peliculas"] = new SelectList(_context.Peliculas, "titulo", "titulo", entrada.pelicula);
            return View(entrada);
        }

        // POST: Entrada/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,usuario,email,pelicula,sala,fila,butaca,fecha")] Entrada entrada)
        {
            if (id != entrada.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Verificar si la entrada ya existe en la base de datos
                bool entradaExistente = await _context.Entradas.AnyAsync(e =>
                    e.pelicula == entrada.pelicula &&
                    e.sala == entrada.sala &&
                    e.fila == entrada.fila &&
                    e.butaca == entrada.butaca &&
                    e.fecha == entrada.fecha);

                if (entradaExistente)
                {
                    ModelState.AddModelError("", "La entrada ya está reservada.");
                    ViewData["Peliculas"] = new SelectList(_context.Peliculas, "titulo", "titulo", entrada.pelicula);
                    return View(entrada);
                }

                try
                {
                    // Si no existe, actualizar la entrada en la base de datos
                    _context.Update(entrada);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntradaExists(entrada.Id))
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

            return View(entrada);
        }

        // GET: Entrada/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Entradas == null)
            {
                return NotFound();
            }

            var entrada = await _context.Entradas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (entrada == null)
            {
                return NotFound();
            }

            return View(entrada);
        }

        // POST: Entrada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Entradas == null)
            {
                return Problem("Entity set 'CineDatabaseContext.Entradas'  is null.");
            }
            var entrada = await _context.Entradas.FindAsync(id);
            if (entrada != null)
            {
                _context.Entradas.Remove(entrada);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntradaExists(int id)
        {
          return (_context.Entradas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
