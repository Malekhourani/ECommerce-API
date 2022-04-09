using System;

namespace App.Application.DTOs.Common
{
    public enum Code
    {
        Ok = 200,
        NoContent = 204,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        Error = 500,
    }
}
