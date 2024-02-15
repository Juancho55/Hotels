
using Infra.Interfaces;
using System.Data.SqlClient;
using System.Data;
using Infra.Hotel.Models;
using Models.Hotel;
using System.Net;
using Models.Booking;
using HOTEL.API.ADO.Interface;

namespace Infra.Hotel
{
    public class HotelInfra : IHotel
    {
        private readonly IHotelContext context;

        public HotelInfra(IHotelContext context)
        {
            this.context = context;
        }

        public async Task<bool> SaveHotel(RequestFilterModel request)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter{ ParameterName = "@ACCION", SqlDbType = SqlDbType.Int, Value = Constant.ActionSaveHotel },
                new SqlParameter{ ParameterName = "@HOTELID", SqlDbType = SqlDbType.Int, Value = request.HotelId },
                new SqlParameter{ ParameterName = "@NOMBRE", SqlDbType = SqlDbType.NVarChar, Value = request.Name },
                new SqlParameter{ ParameterName = "@DIRECCION", SqlDbType = SqlDbType.NVarChar, Value = request.Address },
                new SqlParameter{ ParameterName = "@DESCRIPCION", SqlDbType = SqlDbType.NVarChar, Value = request.Description },
                new SqlParameter{ ParameterName = "@HABITACION", SqlDbType =SqlDbType.NVarChar, Value = request.Room },
                new SqlParameter{ ParameterName = "@UBICACION", SqlDbType = SqlDbType.NVarChar, Value = request.Place },
                new SqlParameter{ ParameterName = "@HABITACIONTIPO", SqlDbType = SqlDbType.NVarChar, Value = request.RoomType },
                new SqlParameter{ ParameterName = "@HABITACIONID", SqlDbType = SqlDbType.Int, Value = request.RoomId },
                new SqlParameter{ ParameterName = "@COSTOBASE", SqlDbType = SqlDbType.Decimal, Value = request.BaseCost },
                new SqlParameter{ ParameterName = "@IMPUESTOS", SqlDbType = SqlDbType.Decimal, Value = request.Taxes },
                new SqlParameter{ ParameterName = "@ACTIVA", SqlDbType = SqlDbType.Bit, Value = request.Active },
                new SqlParameter{ ParameterName = "@THIRDID", SqlDbType = SqlDbType.BigInt, Value = request.ThirdId },
                new SqlParameter{ ParameterName = "@RESERVAID", SqlDbType = SqlDbType.BigInt, Value = request.BookingId }
            };

            int result = await context.ExecuteNonQueryAsync("dbo.SP_Hotel", parameters);

            if (result == 0)
                return false;
            else
                return true;
        }

        public async Task<bool> SaveRoom(RequestFilterModel request)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter{ ParameterName = "@ACCION", SqlDbType = SqlDbType.Int, Value = Constant.ActionSaveRoom },
                new SqlParameter{ ParameterName = "@HOTELID", SqlDbType = SqlDbType.Int, Value = request.HotelId },
                new SqlParameter{ ParameterName = "@NOMBRE", SqlDbType = SqlDbType.NVarChar, Value = request.Name },
                new SqlParameter{ ParameterName = "@DIRECCION", SqlDbType = SqlDbType.NVarChar, Value = request.Address },
                new SqlParameter{ ParameterName = "@DESCRIPCION", SqlDbType = SqlDbType.NVarChar, Value = request.Description },
                new SqlParameter{ ParameterName = "@HABITACION", SqlDbType =SqlDbType.NVarChar, Value = request.Room },
                new SqlParameter{ ParameterName = "@UBICACION", SqlDbType = SqlDbType.NVarChar, Value = request.Place },
                new SqlParameter{ ParameterName = "@HABITACIONTIPO", SqlDbType = SqlDbType.NVarChar, Value = request.RoomType },
                new SqlParameter{ ParameterName = "@HABITACIONID", SqlDbType = SqlDbType.Int, Value = request.RoomId },
                new SqlParameter{ ParameterName = "@COSTOBASE", SqlDbType = SqlDbType.Decimal, Value = request.BaseCost },
                new SqlParameter{ ParameterName = "@IMPUESTOS", SqlDbType = SqlDbType.Decimal, Value = request.Taxes },
                new SqlParameter{ ParameterName = "@ACTIVA", SqlDbType = SqlDbType.Bit, Value = request.Active },
                new SqlParameter{ ParameterName = "@THIRDID", SqlDbType = SqlDbType.BigInt, Value = request.ThirdId },
                new SqlParameter{ ParameterName = "@RESERVAID", SqlDbType = SqlDbType.BigInt, Value = request.BookingId }
            };

            int result = await context.ExecuteNonQueryAsync("SP_Hotel", parameters);

            if (result == 0)
                return false;
            else
                return true;
        }

        public async Task<bool> UpdateHotel(RequestFilterModel request)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter{ ParameterName = "@ACCION", SqlDbType = SqlDbType.Int, Value = Constant.ActionUpdateHotel },
                new SqlParameter{ ParameterName = "@HOTELID", SqlDbType = SqlDbType.Int, Value = request.HotelId },
                new SqlParameter{ ParameterName = "@NOMBRE", SqlDbType = SqlDbType.NVarChar, Value = request.Name },
                new SqlParameter{ ParameterName = "@DIRECCION", SqlDbType = SqlDbType.NVarChar, Value = request.Address },
                new SqlParameter{ ParameterName = "@DESCRIPCION", SqlDbType = SqlDbType.NVarChar, Value = request.Description },
                new SqlParameter{ ParameterName = "@HABITACION", SqlDbType =SqlDbType.NVarChar, Value = request.Room },
                new SqlParameter{ ParameterName = "@UBICACION", SqlDbType = SqlDbType.NVarChar, Value = request.Place },
                new SqlParameter{ ParameterName = "@HABITACIONTIPO", SqlDbType = SqlDbType.NVarChar, Value = request.RoomType },
                new SqlParameter{ ParameterName = "@HABITACIONID", SqlDbType = SqlDbType.Int, Value = request.RoomId },
                new SqlParameter{ ParameterName = "@COSTOBASE", SqlDbType = SqlDbType.Decimal, Value = request.BaseCost },
                new SqlParameter{ ParameterName = "@IMPUESTOS", SqlDbType = SqlDbType.Decimal, Value = request.Taxes },
                new SqlParameter{ ParameterName = "@ACTIVA", SqlDbType = SqlDbType.Bit, Value = request.Active },
                new SqlParameter{ ParameterName = "@THIRDID", SqlDbType = SqlDbType.BigInt, Value = request.ThirdId },
                new SqlParameter{ ParameterName = "@RESERVAID", SqlDbType = SqlDbType.BigInt, Value = request.BookingId }
            };

            int result = await context.ExecuteNonQueryAsync("SP_Hotel", parameters);

            if (result == 0)
                return false;
            else
                return true;
        }

        public async Task<bool> UpdateRoom(RequestFilterModel request)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter{ ParameterName = "@ACCION", SqlDbType = SqlDbType.Int, Value = Constant.ActionUpdateRoom },
                new SqlParameter{ ParameterName = "@HOTELID", SqlDbType = SqlDbType.Int, Value = request.HotelId },
                new SqlParameter{ ParameterName = "@NOMBRE", SqlDbType = SqlDbType.NVarChar, Value = request.Name },
                new SqlParameter{ ParameterName = "@DIRECCION", SqlDbType = SqlDbType.NVarChar, Value = request.Address },
                new SqlParameter{ ParameterName = "@DESCRIPCION", SqlDbType = SqlDbType.NVarChar, Value = request.Description },
                new SqlParameter{ ParameterName = "@HABITACION", SqlDbType =SqlDbType.NVarChar, Value = request.Room },
                new SqlParameter{ ParameterName = "@UBICACION", SqlDbType = SqlDbType.NVarChar, Value = request.Place },
                new SqlParameter{ ParameterName = "@HABITACIONTIPO", SqlDbType = SqlDbType.NVarChar, Value = request.RoomType },
                new SqlParameter{ ParameterName = "@HABITACIONID", SqlDbType = SqlDbType.Int, Value = request.RoomId },
                new SqlParameter{ ParameterName = "@COSTOBASE", SqlDbType = SqlDbType.Decimal, Value = request.BaseCost },
                new SqlParameter{ ParameterName = "@IMPUESTOS", SqlDbType = SqlDbType.Decimal, Value = request.Taxes },
                new SqlParameter{ ParameterName = "@ACTIVA", SqlDbType = SqlDbType.Bit, Value = request.Active },
                new SqlParameter{ ParameterName = "@THIRDID", SqlDbType = SqlDbType.BigInt, Value = request.ThirdId },
                new SqlParameter{ ParameterName = "@RESERVAID", SqlDbType = SqlDbType.BigInt, Value = request.BookingId }
            };

            int result = await context.ExecuteNonQueryAsync("SP_Hotel", parameters);

            if (result == 0)
                return false;
            else
                return true;
        }

        public async Task<List<ResponseBookingModel>> GetBookingHotel(RequestFilterModel request)
        {
            List<ResponseBookingModel> responseBookingModel = new List<ResponseBookingModel>();
            var parameters = new SqlParameter[]
            {
                new SqlParameter{ ParameterName = "@ACCION", SqlDbType = SqlDbType.Int, Value = Constant.ActionGetBooking },
                new SqlParameter{ ParameterName = "@HOTELID", SqlDbType = SqlDbType.Int, Value = request.HotelId },
                new SqlParameter{ ParameterName = "@NOMBRE", SqlDbType = SqlDbType.NVarChar, Value = request.Name },
                new SqlParameter{ ParameterName = "@DIRECCION", SqlDbType = SqlDbType.NVarChar, Value = request.Address },
                new SqlParameter{ ParameterName = "@DESCRIPCION", SqlDbType = SqlDbType.NVarChar, Value = request.Description },
                new SqlParameter{ ParameterName = "@HABITACION", SqlDbType =SqlDbType.NVarChar, Value = request.Room },
                new SqlParameter{ ParameterName = "@UBICACION", SqlDbType = SqlDbType.NVarChar, Value = request.Place },
                new SqlParameter{ ParameterName = "@HABITACIONTIPO", SqlDbType = SqlDbType.NVarChar, Value = request.RoomType },
                new SqlParameter{ ParameterName = "@HABITACIONID", SqlDbType = SqlDbType.Int, Value = request.RoomId },
                new SqlParameter{ ParameterName = "@COSTOBASE", SqlDbType = SqlDbType.Decimal, Value = request.BaseCost },
                new SqlParameter{ ParameterName = "@IMPUESTOS", SqlDbType = SqlDbType.Decimal, Value = request.Taxes },
                new SqlParameter{ ParameterName = "@ACTIVA", SqlDbType = SqlDbType.Bit, Value = request.Active },
                new SqlParameter{ ParameterName = "@THIRDID", SqlDbType = SqlDbType.BigInt, Value = request.ThirdId },
                new SqlParameter{ ParameterName = "@RESERVAID", SqlDbType = SqlDbType.BigInt, Value = request.BookingId }
            };

            DataSet dts = await context.Fill("SP_Hotel", parameters);

            if (dts != null)
                if (dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dts.Tables[0].Rows)
                    {
                        ResponseBookingModel response = new ResponseBookingModel();
                        response.NameHotel = dr["Nombre"].ToString();
                        response.Address = dr["Direccion"].ToString();
                        response.Description = dr["Descripcion"].ToString();
                        BookingModel booking = new BookingModel()
                        {
                            Id = long.Parse(dr["Id"].ToString()),
                            DateS = Convert.ToDateTime(dr["FECHAI"].ToString()),
                            DateE = Convert.ToDateTime(dr["FECHAF"].ToString())
                        };
                        response.BookingModels?.Add(booking);

                        responseBookingModel?.Add(response);
                    }
                }

            return responseBookingModel;
        }

        public async Task<ResponstBookingDetailModel> GetBookingDetail(RequestFilterModel request)
        {
            ResponstBookingDetailModel responseBookingModel = new ResponstBookingDetailModel();
            var parameters = new SqlParameter[]
            {
                new SqlParameter{ ParameterName = "@ACCION", SqlDbType = SqlDbType.Int, Value = Constant.ActionGetBookingDetail },
                new SqlParameter{ ParameterName = "@HOTELID", SqlDbType = SqlDbType.Int, Value = request.HotelId },
                new SqlParameter{ ParameterName = "@NOMBRE", SqlDbType = SqlDbType.NVarChar, Value = request.Name },
                new SqlParameter{ ParameterName = "@DIRECCION", SqlDbType = SqlDbType.NVarChar, Value = request.Address },
                new SqlParameter{ ParameterName = "@DESCRIPCION", SqlDbType = SqlDbType.NVarChar, Value = request.Description },
                new SqlParameter{ ParameterName = "@HABITACION", SqlDbType =SqlDbType.NVarChar, Value = request.Room },
                new SqlParameter{ ParameterName = "@UBICACION", SqlDbType = SqlDbType.NVarChar, Value = request.Place },
                new SqlParameter{ ParameterName = "@HABITACIONTIPO", SqlDbType = SqlDbType.NVarChar, Value = request.RoomType },
                new SqlParameter{ ParameterName = "@HABITACIONID", SqlDbType = SqlDbType.Int, Value = request.RoomId },
                new SqlParameter{ ParameterName = "@COSTOBASE", SqlDbType = SqlDbType.Decimal, Value = request.BaseCost },
                new SqlParameter{ ParameterName = "@IMPUESTOS", SqlDbType = SqlDbType.Decimal, Value = request.Taxes },
                new SqlParameter{ ParameterName = "@ACTIVA", SqlDbType = SqlDbType.Bit, Value = request.Active },
                new SqlParameter{ ParameterName = "@THIRDID", SqlDbType = SqlDbType.BigInt, Value = request.ThirdId },
                new SqlParameter{ ParameterName = "@RESERVAID", SqlDbType = SqlDbType.BigInt, Value = request.BookingId }
            };

            DataSet dts = await context.Fill("SP_Hotel", parameters);

            if (dts != null)
                if (dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dts.Tables[0].Rows)
                    {
                        
                        ResponstBookingDetailModel response = new ResponstBookingDetailModel();
                        response.hotel.Name = dr["Nombre"].ToString();
                        response.booking.DateS = Convert.ToDateTime(dr["FEHAI"].ToString());
                        response.booking.DateE = Convert.ToDateTime(dr["FECHAF"].ToString());
                        response.booking.QuantityPerson = int.Parse(dr["CANTIDADPERSONAS"].ToString());
                        response.booking.City = dr["CIUDAD"].ToString();
                        response.room.TypeRoom = dr["HabitacionTipo"].ToString();
                        response.room.Rooms = dr["Habitacion"].ToString();
                        response.room.Place = dr["Ubiacion"].ToString();
                        response.roomDetail.BaseCost = Convert.ToDecimal(dr["CostoBase"].ToString());
                        response.roomDetail.Taxes = Convert.ToDecimal(dr["Impuestos"].ToString());
                        response.ThirdType = dr["TipoPersona"].ToString();
                        response.Third.Add(new ThirdModel()
                        {
                           FirstName = dr["PrimerNombre"].ToString(),
                           SecondName = dr["SegundoNombre"].ToString(),
                           FirstSurName = dr["PrimerApellido"].ToString(),
                           SecondSurName = dr["SegundoApellido"].ToString(),
                           Mail = dr["Email"].ToString(),
                           Phone = dr["TeledonoContacto"].ToString()
                        });
                    }
                }

            return responseBookingModel;
        }

    }
}
