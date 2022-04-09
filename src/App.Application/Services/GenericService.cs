using System;
using App.Application.Contracts.Common;
using App.Application.DTOs.Common;
using Microsoft.Extensions.Logging;

namespace App.Application.Services
{
    public abstract class GenericService
    {
        private readonly IAppService _appService;
        private readonly ILogger _logger;

        protected GenericService(IAppService appService, ILogger logger)
        {
            _appService = appService;
            _logger = logger;
        }
    }
}
