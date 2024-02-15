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

        [HttpPost(Name = "SaveHotel")]
        public async Task<IActionResult> SaveHotel([FromBody] HotelRequestFilterModel model)
        {
                bool result = await hotelService.SaveHotel(new HotelMapperAPI().MapReq(model));

                return new Result.CreateResult(result);
        }

    }
}
