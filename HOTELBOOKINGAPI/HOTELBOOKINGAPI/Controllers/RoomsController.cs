using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using  HOTELBOOKINGAPI.Models;
using  HOTELBOOKINGAPI.Repository;
using  HOTELBOOKINGAPI.Repository.Room;

namespace HOTELBOOKINGAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly IRoom _context;

        public RoomsController(IRoom context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Rooms>> PostRoom(Rooms room)
        {
            try
            {
                var item = await _context.PostRoom(room);
                return Ok(item);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rooms>>> GetRooms()
        {
            try
            {
                var ht = await _context.GetRooms();
                return Ok(ht);
            }
            catch (Exception er)
            {
                return BadRequest(er.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Rooms>> GetRoom(int id)
        {
            try
            {
                var ht = await _context.GetRoom(id);
                return ht;
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Rooms>> PutRoom(int id, Rooms room)
        {
            try
            {
                var ht = await _context.PutRoom(id, room);
                return Ok(ht);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<string> DeleteRoom(int id)
        {

            return await _context.DeleteRoom(id);
        }
    }
}