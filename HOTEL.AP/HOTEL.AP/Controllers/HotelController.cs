using AutoMapper;
using HOTEL.AP.Models.Hotel;
using HOTEL.AP.Models.Mapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Hotel;
using System.Net.Mime;

namespace HOTEL.AP.Controllers
{
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public class HotelController : BaseController
    {
        private readonly IHotelService hotelService;

        public HotelController(IMapper mapper, IHotelService hotelService) : base(mapper)
        {
            this.hotelService = hotelService;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("hotel/Save")]
        public async Task<IActionResult> SaveHotel([FromBody] HotelRequestFilterModel model)
        {
            if (!ModelState.IsValid) return GetBadRequest();

            try
            {
                bool result = await hotelService.SaveHotel(new HotelMapperAPI().MapReq(model));

                return new Result.CreateResult(result);
            }
            catch(Exception ex)
            {
                return GetErrorresult(ex);
            }
        }
    }
}
