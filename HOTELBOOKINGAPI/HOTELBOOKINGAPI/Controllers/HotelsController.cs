using HOTELBOOKINGAPI.Models;
using Microsoft.AspNetCore.Mvc;


{
    public class HotelsController
    {
}
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HOTELBOOKINGAPI.Models;
using HOTELBOOKINGAPI.Repository;
using Microsoft.AspNetCore.Authorization;

namespace HOTELBOOKINGAPI.Controllers
    //[Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotel _context;

        public HotelsController(IHotel context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Hotels>> PostHotel(Hotels hotel)
        {
            try
            {
                var item = await _context.PostHotel(hotel);
                return Ok(item);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotels>>> GetHotels()
        {
            try
            {
                var ht = await _context.GetHotels();
                return Ok(ht);
            }
            catch (Exception er)
            {
                return BadRequest(er.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hotels>> GetHotel(int id)
        {
            try
            {
                var ht = await _context.GetHotel(id);
                return ht;
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Hotels>> PutHotel(int id, Hotels hotels)
        {
            try
            {
                var ht = await _context.PutHotel(id, hotels);
                return Ok(ht);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<string> DeleteHotel(int id)
        {

            return await _context.DeleteHotel(id);
        }
    }
}