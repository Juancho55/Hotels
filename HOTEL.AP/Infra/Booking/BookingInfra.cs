using HOTEL.API.ADO.Interface;
using Infra.Hotel.Models;
using Infra.Interfaces;
using System.Data.SqlClient;
using System.Data;
using Models.Hotel;
using Infra.Booking.Models;

namespace Infra.Booking
{
    public class BookingInfra : IBooking
    {
        private readonly IHotelContext context;
        public BookingInfra(IHotelContext context)
        {
            this.context = context;
        }

        public async Task<bool> SaveBooking(RequestFilterBookingModel request)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter{ ParameterName = "@ACCION", SqlDbType = SqlDbType.Int, Value = Constant.ActionSaveBooking },
                new SqlParameter{ ParameterName = "@FECHAI", SqlDbType = SqlDbType.DateTime, Value = request.DateStart },
                new SqlParameter{ ParameterName = "@FECHAF", SqlDbType = SqlDbType.DateTime, Value = request.DateEnd },
                new SqlParameter{ ParameterName = "@CIUDAD", SqlDbType = SqlDbType.NVarChar, Value = request.City },
                new SqlParameter{ ParameterName = "@PERSONAS", SqlDbType = SqlDbType.Int, Value = request.QuanityPersons },
                new SqlParameter{ ParameterName = "@THIRDID", SqlDbType =SqlDbType.BigInt, Value = request.ThirId },
                new SqlParameter{ ParameterName = "@HABITACIONID", SqlDbType = SqlDbType.Int, Value = request.RoomId },
                new SqlParameter{ ParameterName = "@PRIMERNOMBRE", SqlDbType = SqlDbType.NVarChar, Value = request.FirstName },
                new SqlParameter{ ParameterName = "@SEGUNDONOMBRE", SqlDbType = SqlDbType.NVarChar, Value = request.SecondName },
                new SqlParameter{ ParameterName = "@PRIMERAPELLIDO", SqlDbType = SqlDbType.NVarChar, Value = request.FirstSurName },
                new SqlParameter{ ParameterName = "@SEGUNDOAPELLIDO", SqlDbType = SqlDbType.NVarChar, Value = request.SecondSurName },
                new SqlParameter{ ParameterName = "@FECHANACIMIENTO", SqlDbType = SqlDbType.DateTime, Value = request.BirthDate },
                new SqlParameter{ ParameterName = "@GENEROID", SqlDbType = SqlDbType.Int, Value = request.GenderId },
                new SqlParameter{ ParameterName = "@TIPODOCUMENTO", SqlDbType = SqlDbType.Int, Value = request.DocumentTypeId },
                new SqlParameter{ ParameterName = "@NUMERODOCUMENTO", SqlDbType = SqlDbType.Int, Value = request.DoumentNumber },
                new SqlParameter{ ParameterName = "@EMAIL", SqlDbType = SqlDbType.NVarChar, Value = request.Mail },
                new SqlParameter{ ParameterName = "@TELEFONO", SqlDbType = SqlDbType.NVarChar, Value = request.Phone },
                new SqlParameter{ ParameterName = "@THIRDTYPEID", SqlDbType = SqlDbType.Int, Value = request.ThirTypeId },
                new SqlParameter{ ParameterName = "@RESERVAID", SqlDbType = SqlDbType.BigInt, Value = request.BookingId }
            };

            int result = await context.ExecuteNonQueryAsync("dbo.SP_Reserva", parameters);

            if (result == 0)
                return false;
            else
                return true;
        }

        public async Task<bool> SaveThird(RequestFilterBookingModel request)
        {
            var parameters = new SqlParameter[]
            {
                new SqlParameter{ ParameterName = "@ACCION", SqlDbType = SqlDbType.Int, Value = Constant.ActionSaveThirdByType },
                new SqlParameter{ ParameterName = "@FECHAI", SqlDbType = SqlDbType.DateTime, Value = request.DateStart },
                new SqlParameter{ ParameterName = "@FECHAF", SqlDbType = SqlDbType.DateTime, Value = request.DateEnd },
                new SqlParameter{ ParameterName = "@CIUDAD", SqlDbType = SqlDbType.NVarChar, Value = request.City },
                new SqlParameter{ ParameterName = "@PERSONAS", SqlDbType = SqlDbType.Int, Value = request.QuanityPersons },
                new SqlParameter{ ParameterName = "@THIRDID", SqlDbType =SqlDbType.BigInt, Value = request.ThirId },
                new SqlParameter{ ParameterName = "@HABITACIONID", SqlDbType = SqlDbType.Int, Value = request.RoomId },
                new SqlParameter{ ParameterName = "@PRIMERNOMBRE", SqlDbType = SqlDbType.NVarChar, Value = request.FirstName },
                new SqlParameter{ ParameterName = "@SEGUNDONOMBRE", SqlDbType = SqlDbType.NVarChar, Value = request.SecondName },
                new SqlParameter{ ParameterName = "@PRIMERAPELLIDO", SqlDbType = SqlDbType.NVarChar, Value = request.FirstSurName },
                new SqlParameter{ ParameterName = "@SEGUNDOAPELLIDO", SqlDbType = SqlDbType.NVarChar, Value = request.SecondSurName },
                new SqlParameter{ ParameterName = "@FECHANACIMIENTO", SqlDbType = SqlDbType.DateTime, Value = request.BirthDate },
                new SqlParameter{ ParameterName = "@GENEROID", SqlDbType = SqlDbType.Int, Value = request.GenderId },
                new SqlParameter{ ParameterName = "@TIPODOCUMENTO", SqlDbType = SqlDbType.Int, Value = request.DocumentTypeId },
                new SqlParameter{ ParameterName = "@NUMERODOCUMENTO", SqlDbType = SqlDbType.Int, Value = request.DoumentNumber },
                new SqlParameter{ ParameterName = "@EMAIL", SqlDbType = SqlDbType.NVarChar, Value = request.Mail },
                new SqlParameter{ ParameterName = "@TELEFONO", SqlDbType = SqlDbType.NVarChar, Value = request.Phone },
                new SqlParameter{ ParameterName = "@THIRDTYPEID", SqlDbType = SqlDbType.Int, Value = request.ThirTypeId },
                new SqlParameter{ ParameterName = "@RESERVAID", SqlDbType = SqlDbType.BigInt, Value = request.BookingId }
            };

            int result = await context.ExecuteNonQueryAsync("dbo.SP_Reserva", parameters);

            if (result == 0)
                return false;
            else
                return true;
        }

        public async Task<List<ResponseOpenBooking>> GetBookingOpen(RequestFilterBookingModel request)
        {
            List<ResponseOpenBooking> responseBookingOpen = new List<ResponseOpenBooking>();
            var parameters = new SqlParameter[]
            {
                new SqlParameter{ ParameterName = "@ACCION", SqlDbType = SqlDbType.Int, Value = Constant.ActionGetOpenBooking },
                new SqlParameter{ ParameterName = "@FECHAI", SqlDbType = SqlDbType.DateTime, Value = request.DateStart },
                new SqlParameter{ ParameterName = "@FECHAF", SqlDbType = SqlDbType.DateTime, Value = request.DateEnd },
                new SqlParameter{ ParameterName = "@CIUDAD", SqlDbType = SqlDbType.NVarChar, Value = request.City },
                new SqlParameter{ ParameterName = "@PERSONAS", SqlDbType = SqlDbType.Int, Value = request.QuanityPersons },
                new SqlParameter{ ParameterName = "@THIRDID", SqlDbType =SqlDbType.BigInt, Value = request.ThirId },
                new SqlParameter{ ParameterName = "@HABITACIONID", SqlDbType = SqlDbType.Int, Value = request.RoomId },
                new SqlParameter{ ParameterName = "@PRIMERNOMBRE", SqlDbType = SqlDbType.NVarChar, Value = request.FirstName },
                new SqlParameter{ ParameterName = "@SEGUNDONOMBRE", SqlDbType = SqlDbType.NVarChar, Value = request.SecondName },
                new SqlParameter{ ParameterName = "@PRIMERAPELLIDO", SqlDbType = SqlDbType.NVarChar, Value = request.FirstSurName },
                new SqlParameter{ ParameterName = "@SEGUNDOAPELLIDO", SqlDbType = SqlDbType.NVarChar, Value = request.SecondSurName },
                new SqlParameter{ ParameterName = "@FECHANACIMIENTO", SqlDbType = SqlDbType.DateTime, Value = request.BirthDate },
                new SqlParameter{ ParameterName = "@GENEROID", SqlDbType = SqlDbType.Int, Value = request.GenderId },
                new SqlParameter{ ParameterName = "@TIPODOCUMENTO", SqlDbType = SqlDbType.Int, Value = request.DocumentTypeId },
                new SqlParameter{ ParameterName = "@NUMERODOCUMENTO", SqlDbType = SqlDbType.Int, Value = request.DoumentNumber },
                new SqlParameter{ ParameterName = "@EMAIL", SqlDbType = SqlDbType.NVarChar, Value = request.Mail },
                new SqlParameter{ ParameterName = "@TELEFONO", SqlDbType = SqlDbType.NVarChar, Value = request.Phone },
                new SqlParameter{ ParameterName = "@THIRDTYPEID", SqlDbType = SqlDbType.Int, Value = request.ThirTypeId },
                new SqlParameter{ ParameterName = "@RESERVAID", SqlDbType = SqlDbType.BigInt, Value = request.BookingId }
            };

            DataSet dts = await context.Fill("SP_Reserva", parameters);

            if (dts != null)
                if (dts.Tables.Count > 0 && dts.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dts.Tables[0].Rows)
                    {
                        ResponseOpenBooking response = new ResponseOpenBooking();
                        response.BookingId = int.Parse(dr["Id"].ToString());
                        response.HotelName = dr["Nombre"].ToString();
                        response.RoomType = dr["HabitacionTipo"].ToString();
                        response.RoomName = dr["Habitacion"].ToString();
                        response.Place = dr["Ubicacion"].ToString();
                        response.BaseCost = Convert.ToDecimal(dr["CostoBase"].ToString());
                        response.Taxes = Convert.ToDecimal(dr["Impuestos"].ToString());

                        responseBookingOpen?.Add(response);
                    }
                }

            return responseBookingOpen;
        }
    }
}
