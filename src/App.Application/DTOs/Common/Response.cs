using System;

namespace App.Application.DTOs.Common
{
    public class Response
    {
        public string Message { get; set; }
        public object Data { get; set; }
        public Code HttpCode { get; set; }

        public static Response Ok(object data, string message = "Success")
        {
            return new Response
            {
                Data = data,
                HttpCode = Code.Ok,
                Message = message
            };
        }

        public static Response NotFound(string message = "No Data was Found")
        {
            return new Response
            {
                HttpCode = Code.NotFound,
                Message = message
            };
        }

        public static Response Forbidden(string message = "You Don't Have the suitable Permission")
        {
            return new Response
            {
                HttpCode = Code.Forbidden,
                Message = message
            };
        }


        public static Response Error(string message = "Something went wrong")
        {
            return new Response
            {
                HttpCode = Code.Error,
                Message = message
            };
        }

        public static Response NoContent(string message = "No Content")
        {
            return new Response
            {
                HttpCode = Code.NoContent,
                Message = message
            };
        }

        public static Response BadRequest(string message)
        {
            return new Response
            {
                HttpCode = Code.BadRequest,
                Message = message
            };
        }

        public static Response Unauthorized()
        {
            return new Response
            {
                HttpCode = Code.Unauthorized,
                Message = "You Need to Login First."
            };
        }
    }
}
