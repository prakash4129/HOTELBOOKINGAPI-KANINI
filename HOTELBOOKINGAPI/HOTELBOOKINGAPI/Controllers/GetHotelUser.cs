using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kanini_Assessment.Models;
using Kanini_Assessment.Repository;
using Microsoft.AspNetCore.Authorization;
using Kanini_Assessment.Repository.HotelsUser;

namespace HOTELBOOKINGAPI.Controllers
{
    [Route("api/GetHotelUser")]
    [ApiController]
    public class GetHotelUser : ControllerBase
    {
        private readonly IHotelUsere _context;

        public GetHotelUser(IHotelUsere context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelUser>>> GetAvailableHotels()
        {
            try
            {
                var ok = await _context.GetAvailableHotels();
                return Ok(ok);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("Availableplacehotels")]
        public async Task<ActionResult<IEnumerable<HotelUser>>> GetAvailablePlaceHotels()
        {
            try
            {
                var ok = await _context.GetAvailablePlaceHotels();
                return Ok(ok);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        [HttpGet("AvailablePricehotels")]
        public async Task<ActionResult<IEnumerable<HotelUser>>> GetAvailablePriceHotels()
        {
            try
            {
                var ok = await _context.GetAvailablePriceHotels();
                return Ok(ok);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

    }
}