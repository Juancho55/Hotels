﻿using Infra.Interfaces;
using Services.Services.Hotel.Mapper;
using Services.Services.Hotel.Models;

namespace Services.Services.Hotel
{
    public class HotelService : IHotelService
    {
        private readonly IHotel hotel;

        public HotelService(IHotel hotel)
        {
            this.hotel = hotel;
        }

        public async Task<bool> SaveHotel(RequestHotelServiceModel model)
        {
            return await hotel.SaveHotel(new HotelMap().MapReq(model));
        }

        public async Task<List<ResponseBookingServiceModel>> GetBooking(RequestHotelServiceModel model)
        {
            return new HotelMap().MapRes(await hotel.GetBookingHotel(new HotelMap().MapReq(model)));
        }
    }
}
