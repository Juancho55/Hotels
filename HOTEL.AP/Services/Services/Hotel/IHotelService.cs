﻿using Infra.Interfaces;
using Services.Services.Hotel.Mapper;
using Services.Services.Hotel.Models;

namespace Services.Services.Hotel
{
    public interface IHotelService
    {
        public Task<bool> SaveHotel(RequestHotelServiceModel model);
        public Task<bool> SaveRoom(RequestHotelServiceModel model);
        public Task<bool> UpdateHotel(RequestHotelServiceModel model);
        public Task<bool> UpdateRoom(RequestHotelServiceModel model);
        public Task<List<ResponseBookingServiceModel>> GetBooking(RequestHotelServiceModel model);
    }
}
