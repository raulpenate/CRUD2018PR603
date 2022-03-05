using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD2018PR603.Data;
using CRUD2018PR603.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD2018PR603.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquiposControlerController : ControllerBase
    {
        private readonly DataContext _context;
        
        //Inyeccion de dependencias
        public EquiposControlerController(DataContext context)
        {
            _context = context;
        }
        
        //Get
        [HttpGet]
        public async Task<ActionResult<List<Equipo>>> Get()
        {
            return (_context.Equipos != null)
                ? await _context.Equipos.ToListAsync()
                : BadRequest("No hay equipos");
        }
        
        //Get id
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Equipo>>> Get(int id)
        {
            var equipo = _context.Equipos.FindAsync(id);
            if (equipo == null) 
                return BadRequest("No existe ese equipo");
            return Ok(equipo);
        }
        
        //Post
        [HttpPost]
        public async Task<ActionResult<List<Equipo>>> Post(Equipo equipo)
        {
                _context.Equipos.Add(equipo);
                await _context.SaveChangesAsync();

                return Ok(await _context.Equipos.ToListAsync());
        }
        
        //Put
        [HttpPut]
        public async Task<ActionResult<List<Equipo>>> Put(Equipo request)
        {
            var equipoDb = await _context.Equipos.FindAsync(request.id_equipos);
            if (equipoDb == null)
                return BadRequest("equipo no encontrado");
            
            equipoDb.id_equipos = request.id_equipos;
            equipoDb.nombre = request.nombre;
            equipoDb.descripcion = request.descripcion;
            equipoDb.tipo_equipo_id = request.tipo_equipo_id;
            equipoDb.marca_id = request.marca_id;
            equipoDb.modelo = request.modelo;
            equipoDb.anio_compra = request.anio_compra;
            equipoDb.costo = request.costo;
            equipoDb.vida_util = request.vida_util;
            equipoDb.estado_equipo_id = request.estado_equipo_id;
            equipoDb.estado = request.estado;

            await _context.SaveChangesAsync();

            return Ok(_context.Equipos.ToListAsync());
        }
    }
}