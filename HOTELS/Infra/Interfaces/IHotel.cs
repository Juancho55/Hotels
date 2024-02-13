using Infra.Hotel.Models;

namespace Infra.Interfaces
{
    public interface IHotel
    {
        public Task<bool> SaveHotel(RequestFilterModel request);
        public Task<bool> SaveRoom(RequestFilterModel request);
        public Task<bool> UpdateHotel(RequestFilterModel request);
        public Task<bool> UpdateRoom(RequestFilterModel request);
        public Task<List<ResponseBookingModel>> GetBookingHotel(RequestFilterModel request);
        public Task<ResponstBookingDetailModel> GetBookingDetail(RequestFilterModel request);
    }
}
