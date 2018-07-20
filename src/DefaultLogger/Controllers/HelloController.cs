using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DefaultLogger.Controllers {

    [Route("api/[controller]/[action]")]
    public class HelloController : ControllerBase {

        ILogger<HelloController> logger;

        public HelloController(ILogger<HelloController> logger) {
            this.logger = logger;
        }

        [HttpGet]
        public dynamic Hi() {
            logger.LogInformation(" -- Info -- ");
            logger.LogDebug(" -- Debug --");
            logger.LogWarning(" -- Warning --");
            logger.LogError(" -- Error --");
            logger.LogTrace(" -- Trace --");
            logger.LogCritical(" -- Critical --");
            return new {
                Hello = "wk"
            };
        }
    }
}