using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Text;

namespace Timezone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeZoneController : ControllerBase
    {
        private readonly ILogger<TimeZoneController> _logger;

        public TimeZoneController(ILogger<TimeZoneController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string GetTime()
        {
            StringBuilder builder = new StringBuilder();

            // Get the local time zone and the current local time and year.
            var localZone = TimeZoneInfo.Local;
            DateTime currentDate = DateTime.Now;

            // Display the names for standard time and daylight saving 
            // time for the local time zone.
            builder.AppendLine($"Standard time name: {localZone.StandardName}");
            builder.AppendLine($"Daylight saving time name: {localZone.DaylightName}");

            // Display the current date and time and show if they occur 
            // in daylight saving time.
            builder.AppendLine($"Current date and time: {currentDate:F}");
            builder.AppendLine($"Daylight saving time? {localZone.IsDaylightSavingTime(currentDate)}");

            // Get the current Coordinated Universal Time (UTC) and UTC 
            // offset.
            builder.AppendLine($"Coordinated Universal Time: {currentDate.ToUniversalTime():F}");
            builder.AppendLine($"UTC offset: {localZone.GetUtcOffset(currentDate)}");

            return builder.ToString();
        }
    }
}
