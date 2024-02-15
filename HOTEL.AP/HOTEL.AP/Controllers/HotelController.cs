using AutoMapper;
using HOTEL.AP.Models.Hotel;
using HOTEL.AP.Models.Mapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Hotel;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HOTEL.AP.Controllers
{
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Route("[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService hotelService;

        public HotelController(IHotelService hotelService)
        {
            this.hotelService = hotelService;
        }

        [HttpPost("SaveHotel")]
        public async Task<IActionResult> SaveHotel([FromBody] HotelRequestFilterModel model)
        {
            bool result = await hotelService.SaveHotel(new HotelMapperAPI().MapReq(model));
            return new Result.CreateResult(result);
        }

        [HttpPost("SaveRoom")]
        public async Task<IActionResult> SaveRoom([FromBody] HotelRequestFilterModel model)
        {
            bool result = await hotelService.SaveRoom(new HotelMapperAPI().MapReq(model));
            return new Result.CreateResult(result);
        }

        [HttpPut("UpdateHotel")]
        public async Task<IActionResult> UpdateHotel([FromBody] HotelRequestFilterModel model)
        {
            bool result = await hotelService.UpdateHotel(new HotelMapperAPI().MapReq(model));
            return new Result.CreateResult(result);
        }

        [HttpPut("UpdateRoom")]
        public async Task<IActionResult> UpdateRoom([FromBody] HotelRequestFilterModel model)
        {
            bool result = await hotelService.UpdateRoom(new HotelMapperAPI().MapReq(model));
            return new Result.CreateResult(result);
        }

        [HttpGet("GetBooking")]
        public async Task<IActionResult> GetBooking(int thirdId)
        {
            HotelRequestFilterModel model = new HotelRequestFilterModel();
            model.ThirdId = thirdId;
            model.Name = "1";
            model.Room = "1";
            model.Address = "1";
            model.Description = "1";
            model.Place = "1";
            model.RoomType = "1";

            var result = new HotelMapperAPI().MapRes(await hotelService.GetBooking(new HotelMapperAPI().MapReq(model)));
            return Ok(result);
        }
    }
}
