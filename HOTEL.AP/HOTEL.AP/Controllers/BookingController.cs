using HOTEL.AP.Models.Booking;
using HOTEL.AP.Models.Hotel;
using HOTEL.AP.Models.Mapper;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Booking;
using Services.Services.Hotel;
using System.Net.Mime;

namespace HOTEL.AP.Controllers
{
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Route("[controller]")]
    public class BookingController : Controller
    {
        private IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost("SaveBooking")]
        public async Task<IActionResult> SaveBooking([FromBody] BookingRequestModel model)
        {
            bool result = await _bookingService.SaveBooking(new BookingMapper().MapReq(model));
            return new Result.CreateResult(result);
        }

        [HttpPost("SaveThird")]
        public async Task<IActionResult> SaveThird([FromBody] BookingRequestModel model)
        {
            bool result = await _bookingService.SaveThird(new BookingMapper().MapReq(model));
            return new Result.CreateResult(result);
        }

        [HttpGet("GetBooking")]
        public async Task<IActionResult> GetOpenBooking(string city, int quantityPersons, DateTime dateStart, DateTime dateEnd)
        {
            BookingRequestModel model = new BookingRequestModel()
            {
                City = city,
                QuanityPersons = quantityPersons,
                DateStart = dateStart,
                DateEnd = dateEnd,
                FirstName = "1",
                SecondName = "1",
                FirstSurName = "1",
                SecondSurName = "1",
                Mail = "1",
                Phone = "1"
            };
            var result = new BookingMapper().MapRes(await _bookingService.GetOpenBooking(new BookingMapper().MapReq(model)));
            return Ok(result);
        }
    }
}
