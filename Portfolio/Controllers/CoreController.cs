using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Portfolio.Data.Contexts;

namespace Portfolio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoreController : ControllerBase
    {
        private readonly ILogger<CoreController> _logger;
        public ApplicationContext _db;

        public CoreController(ILogger<CoreController> logger, ApplicationContext context)
        {
            _db = context;
            _logger = logger;
            ApplyMigrations(_db);
        }
        public string Json(object payload)
        {
            var json = JsonSerializer.Serialize(payload);
            return json;
        }
        public async Task<IActionResult> GetResult(int status, object payload, string uri)
        {
            var json = Json(payload);
            var log = "StatusCode: " + status + "\nJson: " + json + "\nURI: " + uri;
            LogResponse(log);
            switch (status)
            {
                case StatusCodes.Status200OK:
                    return Ok(payload);
                case StatusCodes.Status201Created:
                    return Created(uri, payload);
                case StatusCodes.Status202Accepted:
                    return Accepted(payload);
                case StatusCodes.Status204NoContent:
                    return NoContent();
                case StatusCodes.Status301MovedPermanently:
                    return RedirectPermanent(uri);
                case StatusCodes.Status302Found:
                    return Redirect(uri);
                case StatusCodes.Status307TemporaryRedirect:
                    return RedirectPreserveMethod(uri);
                case StatusCodes.Status308PermanentRedirect:
                    return RedirectPermanentPreserveMethod(uri);
                case StatusCodes.Status400BadRequest:
                    return BadRequest(payload);
                case StatusCodes.Status401Unauthorized:
                    return Unauthorized(payload);
                case StatusCodes.Status403Forbidden:
                    return Forbid();
                case StatusCodes.Status404NotFound:
                    return NotFound();
                case StatusCodes.Status409Conflict:
                    return Conflict(payload);
                default:
                    return StatusCode(status, payload);
            }
        }
        public void LogResponse(string message)
        {
            _logger.LogInformation(message);
        }
        public void ApplyMigrations(ApplicationContext context)
        {
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
                if (context.Database.EnsureCreated())
                {
                    throw new Exception("Unable to apply migration");
                }
            }
        }
    }
}
