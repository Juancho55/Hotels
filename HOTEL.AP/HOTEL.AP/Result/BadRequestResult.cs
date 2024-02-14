using Microsoft.AspNetCore.Mvc;

namespace HOTEL.AP.Result
{
    public class BadRequestResult : IActionResult
    {
        public readonly Error error = new Error();

        public BadRequestResult(string code, string message)
        {
            error.Code = code;
            error.Message = message;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            BadRequest _errorContent = new BadRequest()
            {
                Error = error
            };

            var objectResult = new ObjectResult(_errorContent)
            {
                StatusCode = StatusCodes.Status400BadRequest
            };

            await objectResult.ExecuteResultAsync(context);
        }
    }

    public class Error
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }

    public class BadRequest
    {
        public Error Error { get; set; }
    }
}
